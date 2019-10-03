using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WpfApp8.Model;
namespace WpfApp8.ViewModel

{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ViewModelPerson _vmPerson;
        private DepartmentViewModel _vmDepartment;

        private ObservableCollection<Person> _persons;
        private ObservableCollection<Department> _departments;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set {
                _persons = value;
                OnPropertyChanged("Persons"); }
        }

        public ObservableCollection<Department> Department
        {
            get { return _departments; }
            set
            {
                _departments = value; OnPropertyChanged("Departments");
            }
        }

        public MainViewModel()
        {
            _vmPerson = new ViewModelPerson();
            _vmDepartment = new DepartmentViewModel();

            _persons = _vmPerson.Person;
            _departments = _vmDepartment.Department;

            _vmPerson.add();
        }

            private void OnPropertyChanged(string parameter)
            {
                PropertyChangedEventHandler ph = PropertyChanged;
                if (ph != null)
                    ph(this, new PropertyChangedEventArgs(parameter));
            }
    }
}
