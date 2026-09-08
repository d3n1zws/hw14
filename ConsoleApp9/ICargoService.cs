namespace ConsoleApp9;
public interface ICargoService
{
    public Customer[] customers { get; }
    public Courier[] couriers { get; }
    public CargoOrder[] orders { get; }
    void AddCustomer(Customer customer);
    void AddCourier(Courier courier);
    void CreateOrder(CargoOrder order);
    void CompleteOrder(int id);
}
