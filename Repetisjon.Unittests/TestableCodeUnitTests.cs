using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Repetisjon.Unittesting
{
    public class TestableCodeUnitTests
    {
        ExternalClassFake externalClassFake = new ExternalClassFake();
        // ER DETTE STORT NOK FOR DERE BAK? 
        [Fact]
        public void Add_ShouldReturnSum_WhenCalledWithTwoIntegers()
        {
            // Arrange
            TestableCode unitUnderTest = GetUnitUnderTest();
            int a = 5;
            int b = 10;
            // Act
            int result = unitUnderTest.Add(a, b);
            // Assert
            Assert.Equal(15, result);
        }

        private  TestableCode GetUnitUnderTest()
        {
            return new TestableCode(externalClassFake);
        }

        [Fact]
        public void SetState_ShouldChangeState_WhenCalledWithNewState()
        {
            // Arrange
            var unitUnderTest = GetUnitUnderTest();
            string newState = "New State";
            // Act
            unitUnderTest.SetState(newState);
            // Assert
            Assert.Equal(newState, unitUnderTest.State);
        }

        [Fact]
        public void External_ShouldCallExternalMethod_WhenCalledWithValue()
        {
            // Arrange
            var unitUnderTest = GetUnitUnderTest();
            int value = 42;
            // Act
            unitUnderTest.External(value);
            // Assert
            Assert.Equal(value, externalClassFake.value);
        }

        [Fact]
        public void Multiply_ShouldReturnProduct_WhenCalledWithTwoIntegers()
        {
            // Arrange
            var unitUnderTest = GetUnitUnderTest();
            int a = 5;
            int b = 10;
            // Act
            int result = unitUnderTest.Multiply(a, b);
            // Assert
            Assert.Equal(50, result);
        }
    }

    public class ExternalClassFake : IExternalClass
    {
        public int value { get; set; }
        public void ExternalMethod(int value)
        {
            this.value = value;
        }
    }
}
