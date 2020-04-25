using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Project_Bomject1.Repositories;
using Project_Bomject1.Models;

namespace Project_Bomject1.Repositories
{
    public class ThemeOfTheDayDataRepository : IThemeOfTheDayDataRepository
    {
        public DataContext dbcontext;

        public ThemeOfTheDayDataRepository(DataContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void SaveNewThemeRecord(ThemeOfTheDayModel model)
        {
            dbcontext.ThemesOfTheDay.Add(model);
            dbcontext.SaveChanges();
        }

        public ThemeOfTheDayModel[] GetAllThemesRecord()
        {
            return dbcontext.ThemesOfTheDay.ToArray();
        }

        public void RemoveThemeRecord(ThemeOfTheDayModel model)
        {
            dbcontext.ThemesOfTheDay.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditThemeRecord(ThemeOfTheDayModel model)
        {
            dbcontext.ThemesOfTheDay.Update(model);
            dbcontext.SaveChanges();
        }

        public ThemeOfTheDayModel FindRecordById(int? id)
        {
            return dbcontext.ThemesOfTheDay.Find(id);
        }
    }
}