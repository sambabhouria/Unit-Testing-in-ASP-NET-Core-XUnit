
using Calculator.Services;
using Xunit;

/// <summary>
/// Note : This unit test project will have dependency to the project that
/// is being tested so you will have to add a reference to the project beingg
/// in the unit test project
/// </summary>
namespace CalculatorTests
{
    public class MathServiceTests
    {
        private MathsService _unitUnderTesting = null;
        public MathServiceTests()
        {
            if (_unitUnderTesting == null)
            {
                // In the contructor , we are creating an instance of class MathService and
                // making it available globally withing the test class MathServiceTests
                _unitUnderTesting = new MathsService();
            }
        }
        /*
         * These test method normally consists of 3 logical to test the conditions
         * 
         * 1=> . Arrange: prepare the data which will be required for testing
         * example : data to use in the scenario along with the expected result
         * 
         * 2=> . Act: call methd which is being tested making use of the data prepared
         * in Arrange & this should return the actual result
         * 
         * 3=> . Assert: Compare expected result and actual result to decide if the test passed or failed.
         */

        [Fact] // this attribute will make these method part of unit testing and execute these methods during each test run
        public void Add()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 13;

            var actual = _unitUnderTesting.Add(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            var actual = _unitUnderTesting.Subtract(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Multiply()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            var actual = _unitUnderTesting.Multiply(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Divide()
        {
            double x1 = 100;
            double x2 = 10;
            double expected = 10;

            var actual = _unitUnderTesting.Divide(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
