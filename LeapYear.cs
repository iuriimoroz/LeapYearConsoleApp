namespace LeapYearApp
{
    public class LeapYear
    {
        //Method which calculates leap year based on algoritm from wikipedia page - https://en.wikipedia.org/wiki/Leap_year
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
