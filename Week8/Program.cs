namespace Week8;

public class Program
{
    static void Main()
    {
    Letter l1 = new Letter("2354", 1.6);
    Letter l2 = new Letter("2355", 0.3);
    Parcel p1 = new Parcel("123", 6.7, "30x20x15");
    Parcel p2 = new Parcel("124", 23, "30x20x15");
    
    l1.PrintInfo();
    p2.PrintInfo();

    CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
    myCargo.AddItem(l1);
    myCargo.AddItem(l2);
    myCargo.AddItem(p1);
    myCargo.AddItem(p2);

    double TC = myCargo.GetTotalCost();
    Console.WriteLine($"Total Coat of all deliveries: {TC}");
    
    }
}