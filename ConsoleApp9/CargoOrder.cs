using Microsoft.VisualBasic;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    public class CargoOrder
    {
        public CargoOrder(int customerId, int courierId, int total, OrderStatus status, DateTime createdAt)
        {
            Id = ++id;
            CustomerId = customerId;
            CourierId = courierId;
            Total = total;
            Status = status;
            CreatedAt = createdAt;
        }

        public int Id { get; }
        private int id = 0;
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public double Total { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Created;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public void UpdateStatus(OrderStatus status)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine("Legv olunmus veya tamamlanmis sifarisin statusunu deyismek olmur");
                return;
            }
            Status = status;
        }

    }
}
