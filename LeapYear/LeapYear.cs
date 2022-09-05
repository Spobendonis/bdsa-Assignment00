namespace LeapYear;

public class LeapYear {
    static void Main(string[] args) {

    }
    public static bool isLeapYear(int year) {
        var leapYear = false;
        if(year % 4 == 0) {
            leapYear = !leapYear;
        }
        return leapYear;
    }
}