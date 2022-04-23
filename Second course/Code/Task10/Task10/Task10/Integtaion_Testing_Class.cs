using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace task10
{
    [TestFixture]
    class Integration_Testing_Class
    {

        [Test]
        public void OperationClass_Test()
        {
            //Arrange
            AverageClass Avg = new AverageClass();
            DiscountClass di = new DiscountClass();



            //Act
            double result = di.Discount(Avg.avg(70, 80, 48));
            double result1 = di.Discount(Avg.avg(70, 80, 48));
            double result2 = di.Discount(Avg.avg(998, 1, 3000));

            //Assert
            Assert.AreEqual(40, result1);
            Assert.AreEqual(52.8, result);
            Assert.AreEqual(1066.4, result2);
        }
    }
}
