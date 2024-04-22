// Bad example violating OCP
public enum VehicleType
{
    Car,
    Motorcycle
}

public class Vehicle
{
    public VehicleType Type { get; set; }

    public double CalculateInsurancePremium()
    {
        double basePremium = 1000;

        // Calculate insurance premium based on vehicle type
        if (Type == VehicleType.Car)
        {
            return basePremium * 1.5;
        }
        else if (Type == VehicleType.Motorcycle)
        {
            return basePremium * 2;
        }

        return basePremium;
    }
}

// Good example following OCP
public abstract class Vehicle
{
    public abstract double CalculateInsurancePremium();
}

public class Car : Vehicle
{
    public override double CalculateInsurancePremium()
    {
        double basePremium = 1000;
        return basePremium * 1.5;
    }
}

public class Motorcycle : Vehicle
{
    public override double CalculateInsurancePremium()
    {
        double basePremium = 1000;
        return basePremium * 2;
    }
}