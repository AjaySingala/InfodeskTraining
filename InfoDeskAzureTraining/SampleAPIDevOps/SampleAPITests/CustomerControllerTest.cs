using SampleAPI.Controllers;
using SampleAPI.Repositories;

namespace SampleAPITests
{
    public class CustomerControllerTest
    {
        [Fact]
        public void GetCustomerByID()
        {
            // Arrange.
            CustomerController controller = new CustomerController();
            var expectedFirstname = "John";

            // Act.
            var result = controller.Get(1);
            var fname = result.Firstname;

            // Assert.
            Assert.Equal(expectedFirstname, fname);
        }

        //[Fact]
        //public void GetCustomerByIDDummyData()
        //{
        //    // Arrange.
        //    ICustomerRepository repository = new TestCustomerRepository();
        //    CustomerController controller = new CustomerController(repository);

        //    var expectedLastname = "Test";

        //    // Act.
        //    var result = controller.Get(101);
        //    var lname = result.Lastname;

        //    // Assert.
        //    Assert.Equal(expectedLastname, lname);
        //}
    }
}