namespace ConsoleApp1.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenTwoEmployeesAreNotEqualThenTestIsOK()
        {
            //arrange
            var employee1 = GetEmployee("Rafał","Małkiewicz", "37");
            var employee2 = GetEmployee("Paweł", "Pliszka", "27");
        
            // assert
            Assert.AreNotEqual(employee1, employee2);

        }
        public void WhenTwoEmployeeAreEqualThenTestIsOK()
        {
            //arrange
            var employee3 = GetEmployee("Rafał", "Kowalski", "35");
            var employee4 = GetEmployee("Rafał", "Kowalski", "35");
       
            // assert
            Assert.AreEqual(employee3, employee4);

        }
        [Test]
        public void WhenTwoIntNumbersAreNotEqualThenTestIsOK()
        {
            //arrange
            int number1 = 5;
            int number2 = 10;
       
            // assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void WhenTwoFloatNumbersAreNotEqualThenTestIsOK()
        {
            //arrange
            float number3 = 5.5f;
            float number4 = 10.5f;
          
            // assert
            Assert.AreNotEqual(number3, number4);

        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }
    }
}
