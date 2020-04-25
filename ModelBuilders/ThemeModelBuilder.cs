using Project_Bomject1.ViewModels;
using Project_Bomject1.Models;
using Project_Bomject1.Repositories;
using System.Collections.Generic;

namespace Project_Bomject1.ModelBuilders
{
    public class ThemeModelBuilder : IThemeModelBuilder
    {
        private readonly IThemeOfTheDayDataRepository themeOfTheDayDataRepository;

        public ThemeModelBuilder(IThemeOfTheDayDataRepository themeOfTheDayDataRepository)
        {
            this.themeOfTheDayDataRepository = themeOfTheDayDataRepository;
        }

        public List<ThemeViewModel> GetThemeInfo()
        {
            var modelList = themeOfTheDayDataRepository.GetAllThemesRecord();

            List<ThemeViewModel> ThemeViews = new List<ThemeViewModel>();

            foreach (var item in modelList)
            {
                ThemeViews.Add(new ThemeViewModel
                {
                    Id = item.ThemeOfTheDayId,
                    Name = item.Name,
                    Content = item.Content,
                    Author = item.Author,
                    Date = item.Date
                }
                );
            }

            return ThemeViews;
        }
    }
}
