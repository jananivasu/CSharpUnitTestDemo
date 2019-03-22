using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Services;

namespace Test.UnitTests.Services {
    [TestClass]
    public class TestService_IsEven {
        private readonly TestService _testService;
        public TestService_IsEven() {
            _testService = new TestService();
        }
    [DataTestMethod]
    [DataRow(4)]
    [DataRow(6)]
    [DataRow(8)]
    public void ReturnIsEven(int value)
        {
            var result = _testService.IsEven(value);
            Assert.IsTrue(result,$"{value} is even");
        }

    [DataTestMethod]
    [DataRow(5)]
    [DataRow(7)]
    [DataRow(9)]
    public void ReturnIsOdd(int value)
        {
            var result = _testService.IsEven(value);
            Assert.IsFalse(result,$"{value} is Odd");
        }
    }
}
