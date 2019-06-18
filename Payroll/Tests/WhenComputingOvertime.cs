using NUnit.Framework;
using Payroll;

namespace Tests {

    public class WhenComputingOvertime {

        [Test]
        public void Then41HoursAtTenRate_Returns415(){
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(41, 10);
            Assert.AreEqual(415, wages );
        }

        [Test]
        public void Then80HoursAtTenRate_Returns1000(){
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(80,10);
            Assert.AreEqual(1000, wages);
        }
    }
}