using System.ComponentModel;
using System.Windows.Input;

namespace eDziennik.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        //private string _selectedGradeCB;
        //private int _selectedGradeIndex;
        private string _page;
        public ICommand GradesCmd { get; set; }
        //public ObservableCollection<string> SubjectsCB { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = null;

        public MainWindowViewModel()
        {
            GradesCmd = new RelayCommand(x => ShowGrades());
            Page = "Pages/HomePage.xaml";
        }

        //public GradeCategory SelectedSubjectCB
        //{
        //    get
        //    {
        //        return _selectedSubjectCB;
        //    }
        //    set
        //    {
        //        _selectedSubjectCB = value;
        //        OnPropertyChanged("SelectedSubjectCB");
        //    }
        //}

        //public int SelectedSubjectIndex
        //{
        //    get
        //    {
        //        return _selectedSubjectIndex;
        //    }
        //    set
        //    {
        //        _selectedSubjectIndex = value;
        //        OnPropertyChanged("SelectedSubjectIndex");
        //    }
        //}

        public string Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
                OnPropertyChanged("Page");
            }
        }

        public void ShowGrades()
        {
            Page = "Pages/GradesPage.xaml";
        }

        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
