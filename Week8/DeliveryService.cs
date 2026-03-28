namespace Week8;
    

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
       Console.WriteLine($"Track № {TrackingNumber}, Weight: {Weight}");
    }
}

public class Letter : DeliveryItem
{
    public Letter(string trackNum, double weight) : base(trackNum, weight) {}
    public override double CalculateCost()
    {
        return (Weight * 10) + 15;
    }
}

public class Parcel : DeliveryItem
{
    public string Dimensions { get; }

    public Parcel(string trackNum, double weight, string dimensions) : base(trackNum, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return (Weight * 25) + 50;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var item in _items)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}