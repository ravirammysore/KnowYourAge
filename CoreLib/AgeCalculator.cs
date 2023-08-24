namespace KnowYourAge.CoreLib;

public class AgeCalculator //simple comment
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

    public bool IsLeapYear(DateTime dateOfBirth)
    {
        int year = dateOfBirth.Year;

        if (year % 4 != 0)
        {
            return false;
        }
        else if (year % 100 != 0)
        {
            return true;
        }
        else if (year % 400 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}