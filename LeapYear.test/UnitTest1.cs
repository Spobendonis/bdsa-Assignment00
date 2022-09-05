using Xunit;

namespace LeapYear.test;

public class UnitTest1
{
    [Fact]
    public void Every_4_Years_Is_Leap_Year()
    {
        Assert.True(LeapYear.isLeapYear(4));
        Assert.True(LeapYear.isLeapYear(8));
        Assert.True(LeapYear.isLeapYear(416));
        Assert.True(LeapYear.isLeapYear(444));
        Assert.True(LeapYear.isLeapYear(4804));
        Assert.True(LeapYear.isLeapYear(4824));
        Assert.True(LeapYear.isLeapYear(5220));
        Assert.False(LeapYear.isLeapYear(7));
        Assert.False(LeapYear.isLeapYear(402));
        Assert.False(LeapYear.isLeapYear(499));
        Assert.False(LeapYear.isLeapYear(8010));
    }
}