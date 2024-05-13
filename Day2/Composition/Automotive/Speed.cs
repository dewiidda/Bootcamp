namespace Automotive;

public class Speed
{
    public float velocity;

    //constructor
    public Speed(float velocity)
    {
        this.velocity = velocity;
    }

    public float Speeding(float velocity)
    {
        this.velocity += 10;
        return velocity;
    }
}