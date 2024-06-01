using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace date_time_checker_cs;
static class Program
{
    public static int DaysInMonth(int month, int year)
    {
        int daysInMonth = 0;
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            daysInMonth = 31;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            daysInMonth = 30;
        }
        else if (month == 2)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    daysInMonth = 29;
                }
                else
                {
                    daysInMonth = 28;
                }
            }
            else
            {
                daysInMonth = 28;
            }
        }
        else
        {
            daysInMonth = 0;
        }
        return daysInMonth;
    }

    public static bool IsValidDate(int day, int month, int year)
    {
        int daysInMonth = DaysInMonth(month, year);
        if (month >= 1 && month <= 12)
        {
            if (day >= 1)
            {
                if (day <= daysInMonth)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public static bool CheckDate(string day, string month, string year)
    {
        int parsedDay, parsedMonth, parsedYear;

        if (!int.TryParse(day, out parsedDay) || parsedDay < 1 || parsedDay > 31)
        {
            MessageBox.Show("Input data for Day is incorrect format or out of range");
            return false;
        }

        if (!int.TryParse(month, out parsedMonth) || parsedMonth < 1 || parsedMonth > 12)
        {
            MessageBox.Show("Input data for Month is incorrect format or out of range");
            return false;
        }

        if (!int.TryParse(year, out parsedYear) || parsedYear < 1 || parsedYear > 9999)
        {
            MessageBox.Show("Input data for Year is incorrect format or out of range");
            return false;
        }

        if (IsValidDate(parsedDay, parsedMonth, parsedYear))
        {
            MessageBox.Show($"{day}/{month}/{year} is a valid date");
            return true;
        }
        else
        {
            MessageBox.Show($"{day}/{month}/{year} is NOT a valid date");
            return false;
        }
    }
}