// Bad example violating ISP
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Robot : IWorker
{
    public void Work()
    {
        // Code for performing work
    }

    public void Eat()
    {
        // Robots don't eat!
        throw new NotSupportedException();
    }

    public void Sleep()
    {
        // Robots don't sleep!
        throw new NotSupportedException();
    }
}

// Good example following ISP
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public interface ISleeper
{
    void Sleep();
}

public class Human : IWorker, IEater, ISleeper
{
    public void Work()
    {
        // Code for performing work
    }

    public void Eat()
    {
        // Code for eating
    }

    public void Sleep()
    {
        // Code for sleeping
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        // Code for performing work
    }
}