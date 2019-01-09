using System;

namespace LeapYearApp
{
    class Program
    {
        static void Main()
        {
            var leapYear = new LeapYear();
            Console.WriteLine("Enter a year:");
            try
            {
                int yearProvided = Convert.ToInt32(Console.ReadLine());
                if (yearProvided > 0)   //Not sure when leap years started calculated and used
                {
                    bool status = leapYear.IsLeapYear(yearProvided);

                    if (status)
                    {
                        Console.WriteLine("The year provided is a leap year. Press any key to close the screen...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The year provided is not a leap year.");
                        //calculation of the next leap if user provided not a leap year:
                        do
                        {
                            yearProvided++;
                            status = leapYear.IsLeapYear(yearProvided);
                        } while (status != true);

                        Console.WriteLine($"The next leap year is: {yearProvided}. Press any key to close the screen...");
                        Console.ReadKey();
                    }
                }
                else //When user provided not positive integer or 0 year - he will be prompted to try again
                {
                    Console.WriteLine("Value must be positive integer number. Try again.");
                    Main();
                }
            }
            catch //This statement is executed when user accidentally entered some other characters than numbers - he will be prompted to try again
            { 
                Console.WriteLine("Value must be positive integer number. Try again.");
                Main();
            }
        }
    }

}
