using date_time_checker_cs;
using NUnit.Framework;

[TestFixture]
public class DateTests
{
    [Test]
    public void CheckDate_LowerBoundaryDay_ReturnsTrue()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }
    [Test]
    public void CheckDate_LowerBoundaryDay_ReturnsFalse()
    {
        // Arrange
        string day = "0";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_UpperBoundaryDay_ReturnsTrue()
    {
        // Arrange
        string day = "31";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }
    [Test]
    public void CheckDate_UpperBoundaryDay_ReturnsFalse()
    {
        // Arrange
        string day = "32";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_LowerBoundaryMonth_ReturnsTrue()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_LowerBoundaryMonth_ReturnsFalse()
    {
        // Arrange
        string day = "1";
        string month = "0";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void CheckDate_UpperBoundaryMonth_ReturnsTrue()
    {
        // Arrange
        string day = "1";
        string month = "12";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_UpperBoundaryMonth_ReturnsFalse()
    {
        // Arrange
        string day = "1";
        string month = "13";
        string year = "2000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_LowerBoundaryYear_ReturnsTrue()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "1";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_LowerBoundaryYear_ReturnsFalse()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "0";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void CheckDate_UpperBoundaryYear_ReturnsTrue()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "9999";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_UpperBoundaryYear_ReturnsFalse()
    {
        // Arrange
        string day = "1";
        string month = "1";
        string year = "10000";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_Normal30Day_ReturnsTrue()
    {
        // Arrange
        string day = "30";
        string month = "4";
        string year = "2022";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_Normal30Day_ReturnsFalse()
    {
        // Arrange
        string day = "31";
        string month = "4";
        string year = "2022";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_Normal31Day_ReturnsTrue()
    {
        // Arrange
        string day = "31";
        string month = "1";
        string year = "2022";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_Normal31Day_ReturnsFalse()
    {
        // Arrange
        string day = "32";
        string month = "1";
        string year = "2022";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_FebruaryLeapYear_ReturnsTrue()
    {
        // Arrange
        string day = "29";
        string month = "2";
        string year = "2024";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_FebruaryLeapYear_ReturnsFalse()
    {
        // Arrange
        string day = "30";
        string month = "2";
        string year = "2024";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void CheckDate_FebruaryNormalYear_ReturnsTrue()
    {
        // Arrange
        string day = "28";
        string month = "2";
        string year = "2023";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckDate_FebruaryNormalYear_ReturnsFalse()
    {
        // Arrange
        string day = "29";
        string month = "2";
        string year = "2023";

        // Act
        bool result = Program.CheckDate(day, month, year);

        // Assert
        Assert.IsFalse(result);
    }
}