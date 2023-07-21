namespace FirstCoreAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoSomething_Input0_ReturnValidString()
        {
            // Arrange.
            var obj = new Sample();
            var expected = "You entered 0";

            // Act.
            var result = obj.DoSomething(0);

            // Assert.
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DoSomething_Input15_ReturnStep1()
        {
            // Arrange.
            var obj = new Sample();
            var expected = "Step 1";

            // Act.
            var result = obj.DoSomething(15);

            // Assert.
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DoSomething_Input25_ReturnStep2()
        {
            // Arrange.
            var obj = new Sample();
            var expected = "Step 2";

            // Act.
            var result = obj.DoSomething(25);

            // Assert.
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DoSomething_InputMinus15_ReturnStep2()
        {
            // Arrange.
            var obj = new Sample();
            var expected = "Step 2";

            // Act.
            var result = obj.DoSomething(-15);

            // Assert.
            Assert.Equal(expected, result);
        }
    }

    public class Sample
    {
        public string DoSomething(int i)
        {
            if(i == 0)
            {
                return "You entered 0";
            } else if(i > 10 && i < 20)
            {
                return "Step 1";
            }
            else
            {
                return "Step 2";
            }
        }
    }
}