using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WpfApp8.Model;
using System.Collections.ObjectModel;

namespace WpfApp8.ViewModel
{
    public class ViewModelPerson : INotifyPropertyChanged
    {
        public ViewModelPerson()
        {
            _person = new ObservableCollection<Person>();

        }
        public int  add()
        {
            var p = new Person();
            p.Firstname = _firstName;
            p.Lastname = _lastname;
            p.Number = _number;
            _person.Add(p);
            
            return _person.Count;
        }

        private string _firstName;
        private string _lastname;
        private int _number;
        private ObservableCollection<Person> _person;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; ONPropertChanged("FirstName"); }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; ONPropertChanged("LastName"); }
        }
        public int Number1
        {
            get { return _number; }
            set
            {
                _number = value; ONPropertChanged("Number1");
                    }
        }
        public ObservableCollection<Person> Person
        {
            get { return _person; }
            set { _person = value; ONPropertChanged("Person"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void ONPropertChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
