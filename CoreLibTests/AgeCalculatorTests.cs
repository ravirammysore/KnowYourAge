using KnowYourAge.CoreLib;

namespace KnowYourAge.CoreLibTests;

public class AgeCalculatorTests
{
    
    [Theory]
    [InlineData("01-05-2023", 9)]
    [InlineData("10-05-2022", 365)]
    public void GetAgeInDays_Returns_CorrectAge(string dateOfBirthString, int expectedAgeInDays)
    {
        // Arrange
        var dateOfBirth = DateTime.Parse(dateOfBirthString);

        // Act
        var ageCalculator = new AgeCalculator();
        var actualAgeInDays = ageCalculator.GetAgeInDays(dateOfBirth);

        // Assert
        Assert.Equal(expectedAgeInDays, actualAgeInDays);
    }

    [Theory]
    [InlineData("07-01-2023", 4)]
    [InlineData("08-01-2023", 4)]
    [InlineData("09-04-2023", 1)]
    public void GetAgeInMonths_Returns_CorrectValue(string dateOfBirthString, int expectedAgeInMonths)
    {
        // Arrange
        var dateOfBirth = DateTime.Parse(dateOfBirthString);

        // Act
        var ageCalculator = new AgeCalculator();
        var actualAgeInMonths = ageCalculator.GetAgeInMonths(dateOfBirth);

        // Assert
        Assert.Equal(expectedAgeInMonths, actualAgeInMonths);
    }

}