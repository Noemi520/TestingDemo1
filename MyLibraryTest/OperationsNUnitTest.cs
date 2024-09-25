using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumbers()
        {
            //1. Arrange
            // Operations operations = new Operations();
            //Operations operations = new();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;

            //2. act
            int result = operations.Add(number1, number2);

            //3. Assert
            Assert.That(result, Is.EqualTo(7));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }
        [Test]
        [TestCase(10)]
        [TestCase(11)]
        public void IsEven_InputNumber_ReturnTrue(int number)
        {
            //1. Arrange
            Operations operations = new Operations();
            
            //2.Act
            var result = operations.IsEven(number);
            //3. Assert
            Assert.That(result, Is.True);
            //Assert.That(result, Is.False);

        }
        [Test]
        [TestCase(1.2,2.2)]
        public void AddDecimal_InputDoubleNumber_ReturnDoubleNumber(double number1,double number2)
        {
            Operations operations = new ();

            double result= operations.AddDecimal(number1, number2);

            Assert.That (result, Is.EqualTo(3.4).Within(0.1));
            Assert.That(result, Is.Not.EqualTo(3.6));
            Assert.That(result, Is.Not.EqualTo(3.2));


        }
    }
}
