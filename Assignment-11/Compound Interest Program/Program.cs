/*40) WAP to calculate yearly compound interest for the below inputs
    Principal Amount , Loan Start dATE,  Rate of Interest per year
*/
using System;
using System.Globalization;

namespace Compound_Interest_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            decimal compoundintrest, amount, principal, rate;
            int n, time;


            Console.Write("Enter the principal amount = ");
            principal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("rate Of Intrest= ");
            rate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter compound frequency / year = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Loan start Date:");
            DateTime dtLoanStartDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int NumberOfYears = ((DateTime.Today - dtLoanStartDate).Days) / 365;
            decimal interestAmount = 0, TotalAmountPower;
            decimal originalPricipalAmount = principal;

            for (int tempyear = 1; tempyear <= NumberOfYears; tempyear++)
            {
                interestAmount = principal * (rate / 100.0M);
                principal = principal + interestAmount;

            }

            TotalAmountPower = originalPricipalAmount * (decimal)Math.Pow((double)(1 + (rate / 100.0M)), NumberOfYears);

            // display result upto 2 decimal places
            Console.WriteLine("The toal amount to be paid as on {1}'s date is {0}", Math.Round(principal, 2), DateTime.Today.ToShortDateString());
            Console.WriteLine("The total Amount to be paid calculated using the fpower function as on {1}'s date is {0:N2}", TotalAmountPower, DateTime.Today.ToShortDateString());
        }
    }
}