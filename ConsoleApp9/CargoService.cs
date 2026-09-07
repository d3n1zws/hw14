using System.Diagnostics.Metrics;

namespace ConsoleApp9
{
    internal class CargoService : ICargoService
    {
        Customer[] customers = new Customer[0];
        Courier[] couriers = new Courier[0];
        CargoOrder[] orders = new CargoOrder[0];
        public void AddCourier(Courier courier)
        {
            Array.Resize(ref couriers, couriers.Length + 1);
            couriers[couriers.Length - 1] = courier;
        }
        public void AddCustomer(Customer customer)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = customer;
        }

        public void CreateOrder(CargoOrder order)
        {
            if (order.CourierId == null || order.CustomerId == null)
            {
                throw new ArgumentNullException("id cannot be null");
            }
            if (order.IsAvial)
        }
    }
}
