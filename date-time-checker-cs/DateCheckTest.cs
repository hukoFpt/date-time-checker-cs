using date_time_checker_cs;
using NUnit.Framework;

[TestFixture]
public class DateTests
{
    [Test]
    public void CheckDate_ValidDate_ReturnsTrue()
    {
        // Arrange
        string day = "-1";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void CheckDate_InvalidDate_ReturnsFalse()
    {
        // Arrange
        string day = "31";
        string month = "2";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
}