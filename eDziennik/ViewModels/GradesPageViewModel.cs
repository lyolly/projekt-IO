using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eDziennik.ViewModels
{
    public class GradesPageViewModel:INotifyPropertyChanged
    {
        public ICommand ReturnCmd { get; set; }
        public ICommand AddGradeCmd { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = null;

        public GradesPageViewModel()
        {
            ReturnCmd = new RelayCommand(x => Return());
            AddGradeCmd = new RelayCommand(x => AddGrade());

        }

        public void Return()
        {
            SharedVM.MainVM.Page = "Pages/HomePage.xaml";
        }

        public void AddGrade()
        {
            SharedVM.MainVM.Page = "Pages/AddGradePage.xaml";
        }

        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
