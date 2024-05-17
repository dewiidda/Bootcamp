namespace EnemyProgram;
using System;
using System.Collections.Generic;
public class Enemy
{
    public string Name {get; set;}
    public int Health {get; set;}
    public bool IsAlive => Health > 0;

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public static void UpdateEnemy(List<Enemy> enemies, Action<Enemy> updateAction)
    {
            foreach (var enemy in enemies)
            {
                updateAction(enemy);
            }
    }

    public static Enemy FindEnemy(List<Enemy> enemies, Func<Enemy, bool>match)
    {
        foreach (var enemy in enemies)
        {
            if(match(enemy))
            {
                return enemy;
            }
        }
        return null;
    }

    public static bool AnyEnemy(List<Enemy> enemies, Predicate<Enemy> condition)
    {
        foreach (var enemy in enemies)
        {
            if(condition(enemy))
            {
                return true;
            }
        }
        return false;
    } 
      
}