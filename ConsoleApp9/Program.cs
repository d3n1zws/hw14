using ConsoleApp9;
CargoService cargoservice = new CargoService();

Customer customer1 = new Customer("Deniz", "Baki");
Customer customer2 = new Customer("Leyla", "Gence");
cargoservice.AddCustomer(customer1);
cargoservice.AddCustomer(customer2);

Courier courier1 = new Courier("Nihat");
Courier courier2 = new Courier("Nicat");
cargoservice.AddCourier(courier1);
cargoservice.AddCourier(courier2);

CargoOrder order1 = new CargoOrder(customer1.Id, courier1.Id, 50, OrderStatus.Created,DateTime.Now);
cargoservice.CreateOrder(order1);
Console.WriteLine(order1.Status);
Console.WriteLine(courier1.IsAvaliable);