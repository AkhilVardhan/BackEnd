/*43) WAP to take inputs as mentioned below and display the below message.
    1) input1 : FromDate
    2) input2 : ToDate
    Display : if FromDate is less than todays date then display message as 
		" it is invalid .. FromDate should be equal or more than todays date".
	      if ToDate is higher than todays date then display message as 
	        " it is invalid.. ToDate should be lower or equal to Todays date"/
	     If Today is b/n from date and todate then display message as
		" it is Valid.. Today is b/n FromDate and Todate"
*/
using System;
using System.Globalization;

namespace _43_From_date_is_less_than_the_today_s_date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var FromDate = DateTime.ParseExact("01/01/2022", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var ToDate = DateTime.ParseExact("12/31/2022", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var todaysDate = DateTime.Today;

            if (FromDate > todaysDate)
            {
                Console.WriteLine("It is invalid .. FromDate should be equal or lower than todays date");
            }
            else if (ToDate < todaysDate)
            {
                Console.WriteLine("It is invalid.. ToDate should be higher or equal to Todays date");
            }
            else
            {
                Console.WriteLine("It is Valid.. Today is between FromDate and Todate");
            }
            Console.ReadLine();
        }
    }
}
