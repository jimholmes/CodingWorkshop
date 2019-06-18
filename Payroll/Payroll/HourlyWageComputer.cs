
namespace Payroll
{
    public class HourlyWageComputer
    {
        private const int MAX_STD_HOURS = 40;
        private const decimal OVERTIME_FACTOR = 1.5m;
        public const int ERR_NEGATIVE_HOURS = -1;
        public   const int ERR_NEGATIVE_RATE = -2;
        public const int MAX_HOURLY_RATE = 500;
        

        public decimal ComputeWages(int hoursWorked, int hourlyRate)
        {
            if (hoursWorked < 0)
            {
                return ERR_NEGATIVE_HOURS;
            }
            if (hourlyRate < 0)
            {
                return ERR_NEGATIVE_RATE;
            }

            if (hourlyRate > MAX_HOURLY_RATE)
            {
                throw new System.ArgumentException();
            }
            if (hoursWorked > 80)
            {
                throw new System.ArgumentException();
            }

            if (hoursWorked > MAX_STD_HOURS)
            {
                int stdWages = MAX_STD_HOURS  * hourlyRate;
                int otHours = hoursWorked - MAX_STD_HOURS;
                decimal otWages = otHours * (hourlyRate * OVERTIME_FACTOR);
                return stdWages + otWages;
            }
            return hoursWorked * hourlyRate;
        }
    }
}