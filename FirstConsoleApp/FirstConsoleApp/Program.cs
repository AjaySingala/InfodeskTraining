using FirstConsoleApp.Classes;
using System.Diagnostics;
using Acme.BusinessLayer;

namespace FirstConsoleApp
{
    public class Program
    {
        #region for Orders and Customers.

        static List<Customer> customers = new List<Customer>();
        static List<Product> products = new List<Product>();
        static List<Order> orders = new List<Order>();

        #endregion

        static void Main(string[] args)
        {

            #region data types.

            ////Console.WriteLine("Hello, World!");
            ////int number = 10;
            ////string name = "John Smith";
            ////bool isValid = false;

            ////Console.WriteLine(number);
            ////Console.WriteLine(name);
            ////Console.WriteLine(name + number);
            ////Console.WriteLine(number + name);
            ////Console.WriteLine("Number:" + number + " Name:" + name);
            ////Console.WriteLine($"Number: {number} Name: {name}");

            ////int[] nums = { 1, 2, 3, 4, 5 };
            ////string[] names = { "John", "Mary", "Joe", "Harry" };
            ////Console.WriteLine(nums[0]);
            ////Console.WriteLine(names[3]);

            ////int i = 0;
            ////while(i < nums.Length)
            ////{
            ////    Console.WriteLine($"value = {nums[i]}");
            ////    i++;
            ////}

            ////i = 0;
            ////do
            ////{
            ////    Console.WriteLine($"value = {nums[i]}");
            ////    i++;
            ////} while( i < nums.Length);

            ////for(int x = 0; x < nums.Length; x++)
            ////{
            ////    Console.WriteLine($"value = {nums[x]}");
            ////}

            ////foreach(int num in nums)
            ////{
            ////    Console.WriteLine(num);
            ////}
            ////foreach(string nm in names)
            ////{
            ////    Console.WriteLine(nm);
            ////}

            ////// Data Type Inference.
            ////var val1 = 10;
            ////var val2 = "Ajay";
            ////var val3 = true;

            //////var val4;
            //////var val4 = null;
            ////int y;
            ////y = 202;

            //////val1 = "Hello there!";
            //////Person p1 = new Person();
            //////var p1 = new Person();

            ////Console.WriteLine(names.GetType());
            ////Console.WriteLine(names.ToString());
            ////Console.WriteLine(100.ToString());

            ////Sample car1 = new Sample(1, "John");
            ////Console.WriteLine($"Car Id: {car1.Id}");

            ////Sample car2 = new Sample();
            ////car2.Id = 190;
            ////car2.Name = "BMW";
            ////Console.WriteLine($"Car ID: {car2.Id} Name: {car2.Name}");

            //Car car1 = new Car();
            //BMW bmw1 = new BMW();
            //car1.Start();
            //bmw1.Start();

            //Car somecar = new BMW();
            //somecar.Start();            // Car.Start().
            ////((BMW)somecar).Start();     // BMW.Start();

            #endregion

            #region Data input mechansims.

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine()!;
            //Console.WriteLine($"You entered {name}");

            //Console.Write("Enter something: ");
            //int data = Console.Read();
            //Console.WriteLine($"You entered {data}");

            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();

            #endregion

            #region List

            //List<string> names = new List<string>();
            //List<int> numbers = new List<int>();
            //List<Car> cars = new List<Car>();

            ////Car car1 = new Car(1, 2000, "Toyota");
            //Car car1 = new Car();
            //car1.Id = 1;
            //car1.YearOfManufacture = 2000;
            //car1.Make = "Toyota";
            ////car1.NoOfTyres = 10;      // ERROR!

            //cars.Add(car1);

            //Car car2 = new Car
            //{
            //    Id = 2,
            //    Make = "Honda"
            //};
            //cars.Add(car2);


            //foreach(Car car in cars)
            //{
            //    Console.WriteLine($"Id: {car.Id}, Make: {car.Make}");
            //}

            #endregion


            //#region Order and Customers.

            ////GetCustomers();
            ////PrintCustomers();

            ////GetProducts();
            ////PrintProducts();

            ////GetOrders();
            ////PrintOrders();

            //#endregion

            //try
            //{
            //    //Console.WriteLine("Success!");
            //    //throw new Exception("My Custom Exception.");
            //    int a = 10;
            //    int b = 2;
            //    int c = a / b;

            //    throw new Exception("My Custom Exception.");

            //}
            //catch (DivideByZeroException dbzex)
            //{
            //    Console.WriteLine("Divide by Zero Exception!!!");
            //    Console.WriteLine(dbzex.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception!!!");
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("This executes no matter what!");
            //}

            //try
            //{
            //    // open a conn.
            //    // do some process.
            //    // process.
            //    // Exception.
            //    // process.
            //}
            //finally
            //{
            //    // close conn.
            //}

            ////using(var conn = new Sqlserver(connStr))
            ////{
            ////    // read table data.
            ////    // process it.
            ////}
            ///
            //CustomExceptionDemo();

            //int num = 10;
            //num = num.Add(5);
            //Console.WriteLine(num);

            //Console.WriteLine("this is lower case".AllCaps());
            //string msg = "Hello there!";
            //Console.WriteLine(msg.AllCaps());

            ////"hello".AllCaps();

            //// Boxing and unboxing.
            //int num = 10;
            //Object o = num;             // Boxing.
            //Car somecar = new BMW();    // Boxing.

            //int num2 = (int)o;          // unboxing.
            ////BMW anotherCar = new Car();
            //Car car = new Car();
            ////car.TurnLeft();     // not there!
            //Car car2 = new BMW();

            //BMW anotherCar;
            ////anotherCar = (BMW)car2;
            //((BMW)car2).TurnLeft();

            //EnumDemo("New");
            //EnumDemo("Approved");

            //EnumDemo2(Status.New);
            //EnumDemo2(Status.InProgress);
        }

        static void GetCustomerOrders(int id)
        {
            OrderBL bl = new OrderBL();
            List<Acme.Entities.Order> orders = bl.GetOrders(id);
        }

        static void EnumDemo2(Status status)
        {
            var vals = Enum.GetValues(typeof(Status));
            Console.WriteLine($"Status of the document is: {status}");
            Console.WriteLine($"Numeric value is {(int)status}");
            Console.WriteLine($"Name is {Enum.GetName(typeof(Status), status)}");
            Console.WriteLine($"Here: {status.GetType().GetField(status.ToString())}");
            if (status == Status.New)
                Console.WriteLine("Document created.");
            else if (status == Status.InProgress)
                Console.WriteLine("WIP...");
            else if (status == Status.Approved)
                Console.WriteLine("Document done...");
            else if (status == Status.Rejected)
                Console.WriteLine("Needs work...");
            else
                Console.WriteLine("Unknown status...");
        }

        static void EnumDemo(string status)
        {
            if (status == "New")
                Console.WriteLine("Document created.");
            else if (status == "In Progress")
                Console.WriteLine("WIP...");
            else if (status == "Approved")
                Console.WriteLine("Document done...");
            else if (status == "Rejected")
                Console.WriteLine("Needs work...");
            else
                Console.WriteLine("Unknown status...");

        }

        static void CustomExceptionDemo()
        {
            try
            {
                Divide(10, 2);
                Divide(10, 0);
            }
            catch (MyCustomException mcex)
            {
                Console.WriteLine(mcex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new MyCustomException("You cannot divide by zero!");
            }
            Console.WriteLine(a / b);
        }

        static void PrintOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"ID: {order.Id} | Date: {order.OrderDate} " +
                    $"| Customer: {order.CustomerId} ");

                foreach (var detail in order.Details)
                {
                    var productName = "";
                    foreach (var product in products)
                    {
                        if (product.Id == detail.ProductId)
                        {
                            productName = product.Name;
                            break;
                        }
                    }

                    Console.WriteLine(
                        $"\t | Product: {detail.ProductId}-{productName}" +
                        $"\t | Quantity: {detail.Quantity} " +
                        $"\t | Price: {detail.Price}");
                }
            }
        }

        static void GetOrders()
        {
            while (true)
            {
                Console.Write("Order Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Order Date (dd/mm/yyyy): ");
                string date = Console.ReadLine()!;
                Console.Write("Customer Id: ");
                int customerId = Convert.ToInt32(Console.ReadLine());

                List<OrderDetails> orderDetails = new List<OrderDetails>();
                while (true)
                {
                    Console.Write("Order Details Id: ");
                    int detailsId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Product Id: ");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int qty = Convert.ToInt32(Console.ReadLine());

                    decimal price = 0;

                    foreach (var product in products)
                    {
                        if (product.Id == productId)
                        {
                            price = product.Price;
                            break;
                        }
                    }

                    var detail = new OrderDetails
                    {
                        Id = detailsId,
                        OrderId = id,
                        ProductId = productId,
                        Price = price,
                        Quantity = qty
                    };
                    orderDetails.Add(detail);

                    Console.Write("Add more products to this order (y/n)?: ");
                    var proceed2 = Console.ReadLine();
                    if (proceed2.ToLower() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Order order = new Order
                {
                    Id = id,
                    OrderDate = DateTime.Parse(date)!,
                    CustomerId = customerId!,
                    Details = orderDetails
                    //ProductId = productId!,
                    //Quantity = Convert.ToInt32(qty)!,
                    //Price = price
                };


                orders.Add(order);

                Console.Write("Continue (y/n)?: ");
                string proceed = Console.ReadLine()!;
                if (proceed.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

        }

        static void PrintProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id} | Name: {product.Name} | Price: {product.Price}");
            }
        }

        static void GetProducts()
        {
            while (true)
            {
                Console.Write("Product Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product name: ");
                string name = Console.ReadLine()!;
                Console.Write("Price: ");
                string price = Console.ReadLine()!;

                Product product = new Product
                {
                    Id = id,
                    Name = name!,
                    Price = Convert.ToDecimal(price)
                };

                products.Add(product);

                Console.WriteLine("Continue (y/n)?: ");
                string proceed = Console.ReadLine()!;
                if (proceed.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

        }

        static void PrintCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id} | Name: {customer.Lastname}, {customer.Firstname} | City: {customer.City}");
            }
        }
        static void GetCustomers()
        {
            while (true)
            {
                Console.Write("Customer Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Firstname: ");
                string fname = Console.ReadLine()!;
                Console.Write("Lastname: ");
                string lname = Console.ReadLine()!;
                Console.Write("City: ");
                string city = Console.ReadLine()!;

                Customer customer = new Customer
                {
                    Id = id,
                    Firstname = fname!,
                    Lastname = lname!,
                    City = city!
                };

                customers.Add(customer);

                Console.WriteLine("Continue (y/n)?: ");
                string proceed = Console.ReadLine()!;
                if (proceed.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

        }
    }
}