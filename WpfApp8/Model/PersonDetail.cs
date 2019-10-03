using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class PersonDetail : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        private decimal _salary;
        private int _departmentid;
        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; OnProprertyChanged("FirstName"); }
        }
        public string LastName
        { get { return _lastname; }
            set { _lastname = value; OnProprertyChanged("LastName"); }
        }
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; OnProprertyChanged("Salary"); }
        }
        public int DepartmentId
        {
            get { return _departmentid; }

            set { _departmentid = value; OnProprertyChanged("DepartmentId"); }
        }

       
        private void OnProprertyChanged(string parameter)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
                eventHandler(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
