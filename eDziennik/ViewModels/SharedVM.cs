using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDziennik.ViewModels
{
    public static class SharedVM
    {
        public static GradesPageViewModel GradesVM { get; set; }
        public static MainWindowViewModel MainVM { get; set; }
        public static AddGradePageViewModel AddGradeVM { get; set; }
        public static HomePageViewModel HomeVM { get; set; }

        static SharedVM()
        {
            GradesVM = new GradesPageViewModel();
            MainVM = new MainWindowViewModel();
            AddGradeVM = new AddGradePageViewModel();
            HomeVM = new HomePageViewModel();
        }
    }
}
