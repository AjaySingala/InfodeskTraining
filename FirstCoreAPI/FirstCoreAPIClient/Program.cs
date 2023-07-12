using FirstCoreAPIClient.Models;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace FirstCoreAPIClient
{
    internal class Program
    {
        static string baseAddress = "https://localhost:7123/";
        static HttpClient client = null;

        //static void Main(string[] args)
        //{
            
        //    Console.WriteLine("Done!");
        //}

        static void Main()
        {
            Console.WriteLine("Loading the API...");
            Thread.Sleep(5000);
            Console.WriteLine("Ready!");

            RunAsAsync().GetAwaiter().GetResult();
            //await MyAsyncMethod();
            Console.WriteLine("Press <ENTER> to finish...");
            Console.ReadLine();
        }

        static async Task RunAsAsync()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            // Adds a Content-Type: application/json
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var customer = await GetCustomerAsync(2);
            PrintCustomer(customer);

            var customers = await GetAllCustomersAsync();
            foreach (var cust in customers)
            {
                PrintCustomer(cust);
            }

            //var customerToCreate = new Customer
            //{
            //    Firstname = "Ethan",
            //    Lastname = "Hunt"
            //};
            //var loc = await CreateCustomerAsync(customerToCreate);
            //Console.WriteLine($"Created at {loc}");

            //customer = await GetCustomerAsync(32);
            //customer.Firstname = "Jack";
            //customer.Lastname = "Ryan";
            //await UpdateCustomerAsync(customer);

            await DeleteCustomerAsync(32);
        }

        static void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Id}" +
                $" | {customer.Firstname}" +
                $" | {customer.Lastname}");
        }

        static async Task<Customer> GetCustomerAsync(int id)
        {
            Console.WriteLine();
            Console.WriteLine("GetCustomerAsync(int id)...");

            Customer customer = null;
            var path = $"api/customer";
            var uri = $"{baseAddress}{path}/{id}";

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsAsync<Customer>();
            }

            Console.WriteLine();
            Console.WriteLine("Exiting GetCustomerAsync(int id)...");
            return customer;
        }

        static async Task<List<Customer>> GetAllCustomersAsync()
        {
            Console.WriteLine();
            Console.WriteLine("GetAllCustomersAsync()...");

            List<Customer> customers = null;
            var path = $"api/customer";
            var uri = $"{baseAddress}{path}/";

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                customers = await response.Content.ReadAsAsync<List<Customer>>();
            }

            Console.WriteLine();
            Console.WriteLine("Exiting GetAllCustomersAsync()...");
            return customers;
        }

        static async Task<Uri> CreateCustomerAsync(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine("CreateCustomerAsync(customer)...");

            var path = $"api/customer";
            var uri = $"{baseAddress}{path}";

            HttpResponseMessage response = await client.PostAsJsonAsync(uri, customer);
            response.EnsureSuccessStatusCode();

            var location = response.Headers.Location;

            //// If Customer object returned,
            //// deserialize the object from the response body.
            //// Change return type of this method to Task<Customer>
            //customer = await response.Content.ReadAsAsync<Customer>();
            //return customer;

            Console.WriteLine();
            Console.WriteLine("Exiting CreateCustomerAsync(customer)...");

            return location;
        }

        static async Task UpdateCustomerAsync(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine("UpdateCustomerAsync(customer)...");

            var path = $"api/customer";
            var uri = $"{baseAddress}{path}/{customer.Id}";

            HttpResponseMessage response = await client.PutAsJsonAsync(uri, customer);

            Console.WriteLine();
            Console.WriteLine("Exiting UpdateCustomerAsync(customer)...");
        }

        static async Task DeleteCustomerAsync(int id)
        {
            Console.WriteLine();
            Console.WriteLine("DeleteCustomerAsync(int id)...");

            var path = $"api/customer";
            var uri = $"{baseAddress}{path}/{id}";

            HttpResponseMessage response = await client.DeleteAsync(uri);

            Console.WriteLine();
            Console.WriteLine("Exiting DeleteCustomerAsync(int id)...");
        }
    }
}