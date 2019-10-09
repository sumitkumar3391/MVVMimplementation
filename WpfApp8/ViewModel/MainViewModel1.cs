using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp8.ViewModel
{
    public class MainViewModel1 : INotifyPropertyChanged, ICommand
    {
        private string _firstname;
        private string _lastname;
        private int _salary;
        private int _id;
        private string _name;
        private string _description;
        private PersonViewModel _pvm;
        private ObservableCollection<Model.Person1> _persons;
        private DepartmentViewModel1 _dvm;
        private ObservableCollection<Model.Deaprtment1> _departments;
        private ICommand _addCommand;
        private ICommand _deleteCommand;
        private ICommand _updateCommand;

        private ObservableCollection<Model.PersonDetail> _details;
        private Model.PersonDetail _pd;
        private Model.PersonDetail _selectedItem;
        
      //  private ObservableCollection<Model.PersonDetail> _persondetails;


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public MainViewModel1()
        {
            _pvm = new PersonViewModel();
            _persons = _pvm.Persons;
            _dvm = new DepartmentViewModel1();
            _departments = _dvm.Departments;
            _pd = new Model.PersonDetail();
            _details = new ObservableCollection<Model.PersonDetail>();
          
        }
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }
        public int Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged("Salary");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }

        public ObservableCollection<Model.Person1> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }
        public ObservableCollection<Model.Deaprtment1> Deaprtments
        {
            get { return _departments; }
            set
            {
                _departments = value;
                OnPropertyChanged("Deaprtments");
            }
        }
        public ObservableCollection<Model.PersonDetail> Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }

        }
        public Model.PersonDetail SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new CommandHandler(() => MyAction(), () => CanExecute));
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new CommandHandler(() => MYAction2(), () => CanExecute));
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return _updateCommand ?? (_updateCommand = new CommandHandler(() => myaction3(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                // check if executing is allowed, i.e., validate, check if a process is running, etc. 
                return true;
            }
        }


        public void AddPerson(Model.Person1 person)
        {
            _pvm.Add(person);
        }
        public void AddDepartment(Model.Deaprtment1 department)
        {
            _dvm.add1(department);
           
            

        }
        public  void adddetails( Model.PersonDetail personDetail)
        {
           
            _details.Add(personDetail);
            FirstName = "";
            LastName = "";
            Salary = 0;
            ID = 0;



         }
        public void MyAction()
        {
            var person = new Model.Person1();
            
            person.Id = ID;
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Salary = Salary;
            AddPerson(person);

            var department = new Model.Deaprtment1();
           
            department.Name = Name;
            department.Description = Description;
            department.Id = ID;
            AddDepartment(department);
            int count = _details.Where(x => x.DepartmentId == ID).Count();
            var query = (from j in Deaprtments join i in Persons on j.Id equals i.Id where j.Id == ID && count == 0   select new { i.FirstName, i.LastName, i.Salary, j.Id }).Distinct();
            foreach (var i in query)
            {
                var j = new Model.PersonDetail
                {
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    Salary = i.Salary,
                    DepartmentId = i.Id


                };
                
                    
                
                adddetails(j);
            }
        }
        public void MYAction2()
        {
            _details.Remove(SelectedItem);
        }
        public void myaction3()
        {
            
            SelectedItem.FirstName = FirstName;
            SelectedItem.LastName = LastName;
            SelectedItem.Salary = Salary;


            
        }        






        private void OnPropertyChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }

         bool ICommand.CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
