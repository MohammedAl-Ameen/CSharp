using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace task10
{
    [TestFixture]
    class Unit_Testing_Class
    {
        [Test]
        public void AverageClass_Test()
        {
            //Arrange
            AverageClass Avg = new AverageClass();
           
            
           

            //Act
            double result = Avg.avg(70, 80, 48);
            double result1 = Avg.avg(50, 50, 50);
            double result2 = Avg.avg(90, 99, 3);

            //Assert
            Assert.AreEqual(66, result);
            Assert.AreEqual(50, result1);
            Assert.AreEqual(64, result2);
        }

        [Test]
        public void Discount_Test()
        {
            //Arrange
            DiscountClass Disc = new DiscountClass();

            //Act
            double result1 = Disc.Discount(50);
            double result2 = Disc.Discount(150);
            double result3 = Disc.Discount(30);

            //Assert
            Assert.AreEqual(40, result1);
            Assert.AreEqual(120,result2);
            Assert.AreEqual(27, result3);
        }
    }
}
