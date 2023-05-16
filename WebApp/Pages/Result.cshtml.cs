using System.Globalization;
using KnowYourAge.CoreLib;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KnowYourAge.Pages;
public class ResultModel : PageModel
{
    public int AgeInDays, AgeInWeeks, AgeInMonths, AgeInYears;
    public bool IsLeapYear;

    public void OnGet(string dateOfBirth)
    {
        if (!DateTime.TryParseExact(dateOfBirth, "dd-MM-yyyy", null, DateTimeStyles.None, out DateTime dob))
            throw new ArgumentException("Invalid date format.");

        var ageCalculator = new AgeCalculator();

        AgeInDays = ageCalculator.GetAgeInDays(dob);
        AgeInWeeks = ageCalculator.GetAgeInWeeks(dob);
        AgeInMonths = ageCalculator.GetAgeInMonths(dob);
        AgeInYears = ageCalculator.GetAgeInYears(dob);
        IsLeapYear = ageCalculator.IsLeapYear(dob);
    }
}
