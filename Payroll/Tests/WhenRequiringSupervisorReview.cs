using  NUnit.Framework;
using Payroll;

namespace Tests
{
    /*
    This class holds tests which verify exceptions are thrown for 
    specific situations in the HourlyWageComputer. The use case is that
    hourly rates or hours worked above a threshold should require a supervisor
    review to approve.

    It's important to note that all we are doing is raising the Exception. Some
    other part of the system would need to actually figure out how to 
    flag/notify the supervisor.
     */
    public class WhenRequringSupervisorReview{
      
        /*
        This test uses a "hand-rolled" 'try/catch' block to 
        catch the exception thrown when the hourly rate is too high.

        This shows how a try/catch block works, plus it's an OK test. See 
        below for a more elegant way to test exceptions in NUnit.
         */
        [Test]
        public void ThenHourlyRateOf501_RaisesException() {
            HourlyWageComputer computer = new HourlyWageComputer();

            try
            {
                decimal wages = 
                    computer.ComputeWages(1, HourlyWageComputer.MAX_HOURLY_RATE+1);
            }
            catch (System.ArgumentException)
            {
                Assert.Pass("Argument exception caught");
            }
            Assert.Fail("Exception not caught");
        }

        /*
        This form of testing for an Exception uses NUnit's "Assert.Throws" feature.
        It's a lot cleaner in my view; however it uses a 'lambda' which enables 
        NUnit to monitor the execution of the call to computer.ComputeWages()
        and catch the thrown exception.

        Lambdas are somewhat advanced concepts that don't come in to deep play in 
        most automated testing. Do some reading on them if you're interested.

        For this context it's just enough to know the syntax of it as used for 
        Assert.Throws.
         */
        [Test]
        public void ThenHoursWorkedOf81_RaisesException() {
            HourlyWageComputer computer = new HourlyWageComputer();

            Assert.Throws<System.ArgumentException>( 
                () =>
                computer.ComputeWages(81, 10));
        }
    }
    
}