using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.ViewModel
{
    public class MainViewModel1 : INotifyPropertyChanged
    {
        private PersonViewModel _pvm;
        private ObservableCollection<Model.Person1> _persons;
        private DepartmentViewModel1 _dvm;
        private ObservableCollection<Model.Deaprtment1> _departments;
      
        private ObservableCollection<Model.PersonDetail> _details;
        private Model.PersonDetail _pd;
      //  private ObservableCollection<Model.PersonDetail> _persondetails;


        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel1()
        {
            _pvm = new PersonViewModel();
            _persons = _pvm.Persons;
            _dvm = new DepartmentViewModel1();
            _departments = _dvm.Departments;
            _pd = new Model.PersonDetail();
            _details = new ObservableCollection<Model.PersonDetail>();
          
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

         }
           
          
        
       

        
        private void OnPropertyChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
