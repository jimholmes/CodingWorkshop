using NUnit.Framework;
using Payroll;

namespace Tests
{
    public class WhenComputingStraightTime
    {
        [Test]
        public void ThenOneHourAtTenRate_ReturnsTen() {
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(1, 10);
            Assert.AreEqual(10, wages);
        }

        /* 
        This test uses separate variables to hold hoursWorked and hourlyRate
        instead of passing those values directly to the ComputeWages call.

        This is really a style choice. See which you think is the clearest 
        to you and your team, then be consistent in how you do this.

        I tend to prefer putting the values directly in the method call
                decimal wages = computer.ComputeWages(40,10)
        versus 
                computer.ComputeWages(hoursWorked, hourlyRate)
        because it's fewer lines of code and it's still very clear
        what's happening in the test.

         */
        [Test]
        public void ThenZeroHoursAtTenRate_ReturnsZero()
        {
            HourlyWageComputer computer = new HourlyWageComputer();
            int hoursWorked = 0;
            int hourlyRate = 10;
            decimal wages =  computer.ComputeWages(hoursWorked, hourlyRate);
            Assert.AreEqual(0, wages);
        }

        [Test]
        public void Then40HoursAtTenRate_Returns400() {
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(40,10);
            Assert.AreEqual(400, wages);
        }

        /*
        This test is one we didn't cover in the workshop. It uses NUnit's parameterized
        feature to push several TestCase values through one test method. The TestCase
        parameter values are pulled in by the test method's parameters--note the 
        parameters are well-named and correspond to the various test case values, e.g.

            TestCase(40,10,400) is:
            hoursWorked == 40
            hourlyRate == 10
            expectWages == 400

        In my experience you should be VERY CAREFUL AND THOUGHTFUL when using this approach.
        While it lets you push through lots of data in a hurry, you lose the context of 
        a well-named, well-thought out test method tying to a specific business case value.

        If you decide to use this approach, make sure you're thoughtful and restrict tests to 
        specific areas. For example, I would never, ever mix straight time and overtime tests.
        Doing so blurs the line between testing different use cases.
         */
        [TestCase(0, 10, 0)]
        [TestCase(1,10,10)]
        [TestCase(40,10,400)]
        public void CheckAllStraightTimeBoundaryValues(int hoursWorked, 
                                                        int hourlyRate, 
                                                        decimal expectWages) {
            HourlyWageComputer calculator = new HourlyWageComputer();
            decimal actualWages = calculator.ComputeWages(hoursWorked, hourlyRate);
            Assert.AreEqual(expectWages, actualWages, "TestCase Data: Hours Worked:" + hoursWorked +
                                                                      " Hourly Rate: " + hourlyRate +
                                                                      " Expected: " + expectWages);
        }
    }
}