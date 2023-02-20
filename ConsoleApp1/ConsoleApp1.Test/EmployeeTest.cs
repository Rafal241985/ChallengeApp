namespace ConsoleApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckMaxStatistics()
        {
            var employee = new Employee("Andrzej", "Go³ota");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);
            var statistics= employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void CheckAverageStatistics()
        {
            var employee = new Employee("Andrzej", "Go³ota");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Average);
        }
        [Test]
        public void CheckMinStatistics()
        {
            var employee = new Employee("Andrzej", "Go³ota");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

    }
}