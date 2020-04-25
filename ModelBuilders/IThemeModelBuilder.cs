using Project_Bomject1.ViewModels;
using System.Collections.Generic;

namespace Project_Bomject1.ModelBuilders
{
    public interface IThemeModelBuilder
    {
        List<ThemeViewModel> GetThemeInfo();
    }
}