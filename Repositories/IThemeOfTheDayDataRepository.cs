using Project_Bomject1.Models;
using System.Collections.Generic;

namespace Project_Bomject1.Repositories
{
    public interface IThemeOfTheDayDataRepository
    {
        void EditThemeRecord(ThemeOfTheDayModel model);
        ThemeOfTheDayModel[] GetAllThemesRecord();
        void RemoveThemeRecord(ThemeOfTheDayModel model);
        void SaveNewThemeRecord(ThemeOfTheDayModel model);
        ThemeOfTheDayModel FindRecordById(int? id);
    }
}