using HelloWorld;

namespace TestHelloWorld
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestToString()
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };

            string personToString = person.ToString();
            string expectedValue = "FirstName: John, LastName: Smith";

            Assert.AreEqual(expectedValue, personToString);
        }
    }
}