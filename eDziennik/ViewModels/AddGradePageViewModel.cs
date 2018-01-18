using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eDziennik.ViewModels
{
    public class AddGradePageViewModel:INotifyPropertyChanged
    {
        //private ObservableCollection<Student> _studentList;
        //private GradeCategory _selectedCategoryCB;
        //private int _selectedCategoryIndex;
        //private GradeOption _selectedGradeCB;
        //private int _selectedGradeIndex;
        private string _commentTxt;
        public ICommand HomePageCmd { get; set; }
        public ICommand AddGradeCmd { get; set; }
        public ICommand CancelCmd { get; set; }
        //public Student SelectedStudent { get; set; }
        //public ObservableCollection<GradeCategory> CategoriesCB { get; set; }
        //public ObservableCollection<GradeOption> GradesCB { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = null;

        public AddGradePageViewModel()
        {
            HomePageCmd = new RelayCommand(x => GoToHomePage());
            AddGradeCmd = new RelayCommand(x => AddGrade());
            CancelCmd = new RelayCommand(x => Cancel());
        }

        public string CommentTxt
        {
            get
            {
                return _commentTxt;
            }
            set
            {
                _commentTxt = value;
                OnPropertyChanged("CommentTxt");
            }
        }

        //public ObservableCollection<Student> StudentList
        //{
        //    get
        //    {
        //        return _studentList;
        //    }
        //    set
        //    {
        //        _studentList = value;
        //        OnPropertyChanged("StudentList");
        //    }
        //}

        //public GradeCategory SelectedCategoryCB
        //{
        //    get
        //    {
        //        return _selectedCategoryCB;
        //    }
        //    set
        //    {
        //        _selectedCategoryCB = value;
        //        OnPropertyChanged("SelectedCategoryCB");
        //    }
        //}

        //public int SelectedCategoryIndex
        //{
        //    get
        //    {
        //        return _selectedCategoryIndex;
        //    }
        //    set
        //    {
        //        _selectedCategoryIndex = value;
        //        OnPropertyChanged("SelectedCategoryIndex");
        //    }
        //}

        //public GradeOption SelectedGradeCB
        //{
        //    get
        //    {
        //        return _selectedGradeCB;
        //    }
        //    set
        //    {
        //        _selectedGradeCB = value;
        //        OnPropertyChanged("SelectedGradeCB");
        //    }
        //}

        //public int SelectedGradeIndex
        //{
        //    get
        //    {
        //        return _selectedGradeIndex;
        //    }
        //    set
        //    {
        //        _selectedGradeIndex = value;
        //        OnPropertyChanged("SelectedGradeIndex");
        //    }
        //}

        private void GoToHomePage()
        {
            SharedVM.MainVM.Page = "Pages/HomePage.xaml";
        }

        private void Cancel()
        {
            throw new NotImplementedException();
        }

        private void AddGrade()
        {
            throw new NotImplementedException();
        }

        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
