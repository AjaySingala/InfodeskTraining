using FirstCoreAPI.Tests.MoqDemo;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreAPI.Tests
{
    public class MoqDemoTest
    {
        [Fact]
        public void TestUsingMoqDependency()
        {
            // Arrange.
            // Create a mock version of the interface first.
            var mockDep = new Mock<IThingDependency>();

            // Set up the mock version of the method.
            //mockDep.Setup(t => t.Join("John", "Smith")).Returns("John Smith");
            mockDep.Setup(t => t.Join(It.IsAny<string>(), It.IsAny<string>()))
                .Returns("John Smith");

            // Set up the mock version of the property.
            mockDep.Setup(t => t.Age).Returns(32);

            // Mock the card.
            var card = new Card
            {
                Name = "Peter Quill",
                Number = 1234567890,
                CVV = 666
            };
            mockDep.Setup(t => t.Charge(123, card)).Returns(true);
            //mockDep.Setup(t => t.Charge(It.IsAny<int>(), card)).Returns(true);

            // Create an instance of the class to be tested with DI.
            var classToBeTested = new ThingToBeTested(mockDep.Object);

            // Expected result.
            var expected = "John Smith is 32 years old.";

            // Act.
            var result = classToBeTested.DoTheThing();
            var res2 = classToBeTested.ChargeTheCard(122, card);

            // Assert.
            Assert.Equal(expected, result);
        }
    }
}
