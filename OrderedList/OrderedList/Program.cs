using OrderedList;

Random r = new Random();
var l = new OrderedList<Product>();


l.Add(new Product() { Id = 1, Name = "Product 1", Price = 100 });
l.Add(new Product() { Id = 2, Name = "Product 2", Price = 10 });
l.Add(new Product() { Id = 3, Name = "Product 3", Price = 50 });
l.Add(new Product() { Id = 4, Name = "Product 4", Price = 110 });
l.Add(new Product() { Id = 5, Name = "Product 5", Price = 5 });
//l.Add(new Product() { Id = 3, Name = "Product 3", Price = 50 });

//l.Add(new Product() { Id = 5, Name = "Product 5", Price = 5 });


Console.WriteLine(l);
Console.WriteLine("*******************************");

var l1 = new OrderedList<Product>();

l1.Add(new Product() { Id = 1, Name = "Product 1", Price = 1 });
l1.Add(new Product() { Id = 2, Name = "Product 2", Price = 11 });
l1.Add(new Product() { Id = 3, Name = "Product 3", Price = 55 });
l1.Add(new Product() { Id = 4, Name = "Product 4", Price = 99 });
l1.Add(new Product() { Id = 5, Name = "Product 5", Price = 200 });

Console.WriteLine(l1);
Console.WriteLine("*******************************");