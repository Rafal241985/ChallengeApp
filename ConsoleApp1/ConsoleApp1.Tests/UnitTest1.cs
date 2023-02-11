namespace ConsoleApp1.Tests
{
    public class Tests
    {
        [Test]
        public void WhennEmployeeGetPoints()
        {
            //arrange
            var employee = new Employee("Rafa³", "Ma³kiewicz", "37");
            employee.AddPoints(5);
            employee.AddPoints(10);
            employee.AddPoints(-10);

            //act
            var result = employee.Points;

            // assert
            Assert.AreEqual(5, result);
        }
    }
}