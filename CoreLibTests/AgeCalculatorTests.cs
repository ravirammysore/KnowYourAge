using KnowYourAge.CoreLib;
using System.Globalization;

namespace KnowYourAge.CoreLibTests;

public class AgeCalculatorTests
{
    
    CultureInfo provider = CultureInfo.InvariantCulture;
    string format = "dd-MM-yyyy";

    [Theory]
    [InlineData("01-08-2023", 23)]
    //[InlineData("18-05-2022", 365)]
    public void GetAgeInDays_Returns_CorrectAge(string dateOfBirthString, int expectedAgeInDays)
    {
        // Arrange
        var dateOfBirth = DateTime.ParseExact(dateOfBirthString,format,provider);

        // Act
        var ageCalculator = new AgeCalculator();
        var actualAgeInDays = ageCalculator.GetAgeInDays(dateOfBirth);

        // Assert
        Assert.Equal(expectedAgeInDays, actualAgeInDays);
    }

    [Theory]
    [InlineData("22-04-2023", 4)]
    //[InlineData("08-01-2023", 4)]
    //[InlineData("09-04-2023", 1)]
    public void GetAgeInMonths_Returns_CorrectValue(string dateOfBirthString, int expectedAgeInMonths)
    {
        // Arrange
        var dateOfBirth = DateTime.ParseExact(dateOfBirthString,format,provider);

        // Act
        var ageCalculator = new AgeCalculator();
        var actualAgeInMonths = ageCalculator.GetAgeInMonths(dateOfBirth);

        // Assert
        Assert.Equal(expectedAgeInMonths, actualAgeInMonths);
    }

    [Theory]
    [InlineData("25-12-2020", true)]
    //[InlineData("15-11-2021", false)]          
    public void IsLeapYear_Returns_Correct_Result(string dateOfBirthString, bool expectedIsLeapYear)
    {
        // Arrange
        var ageCalculator = new AgeCalculator();
        var dateOfBirth = DateTime.ParseExact(dateOfBirthString,format,provider);
        
        // Act
        var actualIsLeapYear = ageCalculator.IsLeapYear(dateOfBirth);

        // Assert
        Assert.Equal(expectedIsLeapYear, actualIsLeapYear);
    }
}