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

    [Fact]
    public void Every_100_Years_Not_Leap_Year()
    {
        Assert.False(LeapYear.isLeapYear(100));
        Assert.False(LeapYear.isLeapYear(200));
        Assert.False(LeapYear.isLeapYear(600));
        Assert.False(LeapYear.isLeapYear(1700));
        Assert.False(LeapYear.isLeapYear(1900));
        Assert.False(LeapYear.isLeapYear(2100));
    }

    [Fact]
    public void Every_400_Years_Is_Leap_Year()
    {
        Assert.True(LeapYear.isLeapYear(0));
        Assert.True(LeapYear.isLeapYear(400));
        Assert.True(LeapYear.isLeapYear(800));
        Assert.True(LeapYear.isLeapYear(1200));
        Assert.True(LeapYear.isLeapYear(1600));
        Assert.True(LeapYear.isLeapYear(2000));
        Assert.True(LeapYear.isLeapYear(2400));
    }
}