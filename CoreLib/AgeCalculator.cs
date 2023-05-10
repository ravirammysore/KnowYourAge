namespace KnowYourAge.CoreLib;

public class AgeCalculator
{
    public int GetAgeInDays(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var ageInDays = today.Subtract(dateOfBirth).Days;
        return ageInDays;
    }

    public int GetAgeInWeeks(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var ageInDays = today.Subtract(dateOfBirth).Days;
        var ageInWeeks = (int)Math.Floor(ageInDays / 7.0);
        return ageInWeeks;
    }

    public int GetAgeInMonths(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var ageInMonths = (today.Year - dateOfBirth.Year) * 12 + today.Month - dateOfBirth.Month;
        return ageInMonths;
    }

    public int GetAgeInYears(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        var ageInYears = today.Year - dateOfBirth.Year;
        return ageInYears;
    }
}