namespace LeapYear;

public class LeapYear {
    static void Main(string[] args) {
        string input;
        Console.WriteLine("Welcome, I the undisputed master of the Gregorian Calendar will now answer your question about any date; leap year, yay or nay? Please say a year from 1582 or after!");
        input = Console.ReadLine();
        isLeapYear(input);
    }
    public static bool isLeapYear(string inputYear) {
        var leapYear = false;
        int year;
        try {
            year = Int32.Parse(inputYear);
            if(year < 1582) {
                throw new InvalidDataException();
            }
        } catch (InvalidDataException) {
            Console.WriteLine("This number is too small, It must be greater than 1581!");
            return false;
        } catch (Exception) {
            Console.WriteLine("This is not a number!");
            return false;
        }
        if(year % 4 == 0) {
            leapYear = !leapYear;
        }
        if(year % 100 == 0) {
            leapYear = !leapYear;
        }
        if(year % 400 == 0) {
            leapYear = !leapYear;
        }
        if(leapYear) {
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
        return leapYear;
    }
}