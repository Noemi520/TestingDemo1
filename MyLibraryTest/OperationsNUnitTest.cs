using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        [Test]
        public void GetEvenNumber_InputRange_ReturnEvenNumber() { 
            Operations operations= new ();
            int start = 0;
            int end = 10;
            var result = operations.GetEvenNumber(start, end);  //pongo var en la clase operation ya definimos que variable seria

         
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique); //no tenga valores añadidos
            Assert.That(result, Does.Contain(0));
            Assert.That(result, Does.Contain(10));
            Assert.That(result, Does.Not.Contain(-1));
            Assert.That(result, Does.Not.Contain(11));
            Assert.That(result, Has.Member(6));
            Assert.That(result, Has.No.Member(-1));
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Has.All.InRange(0,8));
           // Assert.That(result,Has.Exactly(5).Items);
           Assert.That(result,Is.EquivalentTo(new[] { 2, 4,  6,  8 }));


        }
        [Test]
        [TestCase(1,20)]
        [TestCase(100,1000)]
        public void GetEvenNumber_SeveralInputRange_returnEvenNumbers(int start,int end)
        {
            Operations operations = new();
            int startNumber=start%2==0?start:start+1;
            int endNumber = end % 2 == 0 ? end : end - 1;
            int middleNumber=(startNumber+endNumber)/2;
            middleNumber=middleNumber%2==0?middleNumber:middleNumber+1;
           
            var result = operations.GetEvenNumber(start, end);  //pongo var en la clase operation ya definimos que variable seria

            Assert.That(end - start >=2,Is.True);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Is.Ordered);
            Assert.That(result, Has.No.All.LessThan(startNumber));
            Assert.That(result, Has.Member(startNumber));
            Assert.That(result, Has.Member(middleNumber));
            Assert.That(result, Has.Member(endNumber));
            Assert.That(result, Has.No.All.GreaterThan(endNumber));
            Assert.That(result, Is.Unique); //no tenga valores añadidos y sean unicos
            //Assert.That(result, Does.Contain(startNumber));
            //Assert.That(result, Does.Contain(endNumber));
            //Assert.That(result, Does.Not.Contain(-1));
            //Assert.That(result, Does.Not.Contain(11));
            //Assert.That(result, Has.All.InRange(startNumber,endNumber));
          //Assert.That(result, Is.EquivalentTo(new[] { 2, 4, 6, 8 }));


        }

    }
}
