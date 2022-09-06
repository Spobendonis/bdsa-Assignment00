namespace LeapYear.test;

public class UnitTest1
{
    [Fact]
    public void Every_4_Years_Is_Leap_Year()
    {
        Assert.True(LeapYear.isLeapYear("2004"));
        Assert.True(LeapYear.isLeapYear("2140"));
        Assert.True(LeapYear.isLeapYear("4804"));
        Assert.True(LeapYear.isLeapYear("4824"));
        Assert.True(LeapYear.isLeapYear("5220"));
        Assert.False(LeapYear.isLeapYear("8010"));
        Assert.False(LeapYear.isLeapYear("8021"));
        Assert.False(LeapYear.isLeapYear("9777"));
    }

    [Fact]
    public void Every_100_Years_Not_Leap_Year()
    {
        Assert.False(LeapYear.isLeapYear("1700"));
        Assert.False(LeapYear.isLeapYear("1900"));
        Assert.False(LeapYear.isLeapYear("2100"));
        Assert.False(LeapYear.isLeapYear("2200"));
        Assert.False(LeapYear.isLeapYear("2300"));
        Assert.False(LeapYear.isLeapYear("2500"));
    }

    [Fact]
    public void Every_400_Years_Is_Leap_Year()
    {
        Assert.True(LeapYear.isLeapYear("1600"));
        Assert.True(LeapYear.isLeapYear("2000"));
        Assert.True(LeapYear.isLeapYear("2400"));
        Assert.True(LeapYear.isLeapYear("10000"));
        Assert.True(LeapYear.isLeapYear("12000"));
        Assert.True(LeapYear.isLeapYear("40000"));
        Assert.True(LeapYear.isLeapYear("80000"));
    }

    [Fact]
    private void Number_Too_Low_Fails()
    {
        Assert.False(LeapYear.isLeapYear("145"));
        Assert.False(LeapYear.isLeapYear("199"));
        Assert.False(LeapYear.isLeapYear("200"));
        Assert.False(LeapYear.isLeapYear("204"));
        Assert.False(LeapYear.isLeapYear("400"));
        Assert.False(LeapYear.isLeapYear("908"));
        Assert.False(LeapYear.isLeapYear("1520"));
    }
    private void Not_A_Number_Fails()
    {
        Assert.False(LeapYear.isLeapYear("Hello"));
        Assert.False(LeapYear.isLeapYear("19 04"));
        Assert.False(LeapYear.isLeapYear("1800x"));
        Assert.False(LeapYear.isLeapYear("rx20000mb"));
        Assert.False(LeapYear.isLeapYear("5000pp"));
        Assert.False(LeapYear.isLeapYear("50 80 pp"));
        Assert.False(LeapYear.isLeapYear("pp 50 80 20"));
    }
}