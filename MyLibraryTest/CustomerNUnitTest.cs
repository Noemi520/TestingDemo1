using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]

    public class CustomerNUnitTest
    {
        [Test]
        public void FullName_RetunEmpty()
        {
            //1.Arrange
            Customer customer = new Customer();

            //2. Act
            string result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.WhiteSpace);
        }

        [Test]
        public void FullName_RetunFullName()
        {
            //1.Arrange
            Customer customer = new Customer { 
                FirstName="Jon",
                LastName="Doe"
            };

            //2. Act
            string result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.Contain("Jon"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Does.StartWith("Jon"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Is.EqualTo("Jon Doe"));
            Assert.That(result,Is.EqualTo("Jon Doe").IgnoreCase)

        }
    }
   
}
