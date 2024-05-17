namespace EnemyProgram;

public class Program
{
    
    public static void Main(string[] args)
    {
        var enemies = new List<Enemy>
        {
            new Enemy("Goblin", 100),
            new Enemy("Orc", 150),
            new Enemy("Troll", 200)            
        };

        //default delegate: action, func, predicate
        Action<Enemy> updateHealth = (x) => x.TakeDamage(10);
        
        Enemy.UpdateEnemy(enemies, updateHealth);

        Console.WriteLine("After updating health:");
        foreach (var enemy in enemies)
        {
            Console.WriteLine($"{enemy.Name} has {enemy.Health} health left.");
        }

        Func<Enemy, bool> findByName = (enemy) => enemy.Name == "Fadl";

        Enemy fadl = Enemy.FindEnemy(enemies, findByName);
        Console.WriteLine(fadl != null ? $"Found enemy: {fadl.Name}" : "Enemy not found");

        Predicate<Enemy> isAlive = (enemy) => enemy.IsAlive;
        
        bool anyAlive = Enemy.AnyEnemy(enemies, isAlive);
        Console.WriteLine(anyAlive ? "There are enemies still alive" : "All enemies are defeated");
    }
}