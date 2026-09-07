using Microsoft.VisualBasic;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    internal class CargoOrder
    {
        public CargoOrder(string id, string customerId, string courierId, int total, OrderStatus status, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            CourierId = courierId;
            Total = total;
            Status = status;
            CreatedAt = createdAt;
        }

        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CourierId { get; set; }
        public int Total { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Created;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public void UpdateStatus(OrderStatus status)
        {
            Status = status;
        }

    }
}
