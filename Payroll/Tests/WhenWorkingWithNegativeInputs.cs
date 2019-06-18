using NUnit.Framework;
using Payroll;

namespace Tests
{
    public class WhenWorkingWithNegativeInputs {

        [Test]
        public void WhenHoursAreNegative_ThenRaiseNegativeHoursError() {
            HourlyWageComputer computer =  new HourlyWageComputer();
            decimal wages = computer.ComputeWages(-1, 10);
            Assert.AreEqual(HourlyWageComputer.ERR_NEGATIVE_HOURS, wages);
        }

        [Test]
        public void WhenRateIsNegative_ThenRaseNegativeRateError() {
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(1,-1);
            Assert.AreEqual(HourlyWageComputer.ERR_NEGATIVE_RATE, wages);
        }
    }
    
}