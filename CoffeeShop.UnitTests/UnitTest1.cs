using NUnit.Framework;

namespace CoffeeShop.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            var myCoffeeShop = new Com.ManchesterDigital.CoffeeShop.CoffeeShop();
            Assert.IsNotNull(myCoffeeShop);
        }
    }
}
