using System;
using Lab3.Models;
namespace Lab3
{

    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }

}


