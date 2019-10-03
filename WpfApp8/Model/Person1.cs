using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class Person1 : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private decimal _salary;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnProprertyChanged("Id");
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set {
                _firstName = value;
                OnProprertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnProprertyChanged("LastName");
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set {
                _salary = value;
                OnProprertyChanged("Salary"); }
        }

        private void OnProprertyChanged(string parameter)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            eventHandler(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
