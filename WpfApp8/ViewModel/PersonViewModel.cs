using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.Model;

namespace WpfApp8.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person1> _persons;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Person1> Persons
        {
            get { return _persons; }
            set {
                _persons = value;
                OnProprertyChanged("Persons");
            }
        }

        public PersonViewModel()
        {
            _persons = new ObservableCollection<Person1>();
        }

        public void Add(Person1 person)
        {
            _persons.Add(person);
        }

        private void OnProprertyChanged(string parameter)
        {
            var eventHandler = PropertyChanged;
            eventHandler(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
