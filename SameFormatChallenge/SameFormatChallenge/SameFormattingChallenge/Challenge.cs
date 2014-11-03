using System;
using System.Globalization;

namespace SameFormattingChallenge
{
    public class Challenge
    {
        // Around the world people show numbers, dates and strings differently
        // Today is the day where the world get together and get a similar format for numbers, dates and strings
        // ...only we went a bit nuts and decided the following:
        
        // Numbers should have x as group seperator, y as decimal seperator and always be 5 decimals (Example: 4563111.45 ==> 4x563x111y45000)
        // Dates should be Month Year Day, year is 4 digit, day is 2 digit and for month the US English name is chosen (Example: 23rd of August 2014 ==> August-2014-23)

        // Implement the two methods for formatting a number to a string and a date to a string.

        public string FormatNumber(decimal inputNumber)
        {
            return inputNumber.ToString("N5", CultureInfo.InvariantCulture).Replace(',', 'x').Replace('.', 'y');
        }

        public string FormatDate(DateTime inputDate)
        {
            return inputDate.ToString("MMMM-yyyy-dd", CultureInfo.InvariantCulture);
        }
    }
}
    