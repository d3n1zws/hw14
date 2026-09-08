using System.Diagnostics.Metrics;

namespace ConsoleApp9
{
    internal class CargoService : ICargoService
    {
        public Customer[] customers = new Customer[0];
        public Courier[] couriers = new Courier[0];
        public CargoOrder[] orders = new CargoOrder[0];

        Customer[] ICargoService.customers => new Customer[0];

        Courier[] ICargoService.couriers => new Courier[0];

        CargoOrder[] ICargoService.orders => new CargoOrder[0];

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
            Courier? courier = null;
            Customer? customer = null;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].Id == order.CustomerId)
                {
                    customer = customers[i];
                    break;
                }
            }
            if (customer == null)
            {
                throw new Exception("Customer tapılmadı");
            }
            for (int i = 0; i < couriers.Length; i++)
            {
                if (couriers[i].Id == order.CourierId)
                {
                    courier = couriers[i];
                    break;
                }
            } 
            if (courier == null)
            {
                throw new Exception("Courier tapilmadi");
            }
            if (!courier.IsAvaliable)
            {
                throw new Exception("Bu kuryer hazirda sifaris qebul ede bilmir");
            }
            courier.IsAvaliable = false;
            Array.Resize(ref orders, orders.Length + 1);
            orders[orders.Length - 1] = order;
        }
        public void CompleteOrder(int id)
        {
            CargoOrder? order = null;
            for (int i = 0; i < orders.Length; i++)
            {
                if (id == orders[i].Id)
                {
                    order = orders[i];
                    break;
                }
            }
            if (order == null)
            {
                throw new Exception("Order tapılmadı");
            }
            order.UpdateStatus(OrderStatus.Delivered);
            Courier? courier = null;
            for (int i = 0; i < couriers.Length; i++)
            {
                if (order.CourierId == couriers[i].Id)
                {
                    courier = couriers[i];
                    break;
                }
            }
            if (courier != null)
            {
                courier.IsAvaliable = true;
            }
        }
    }
}
