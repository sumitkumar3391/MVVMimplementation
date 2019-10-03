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

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel1()
        {
            _pvm = new PersonViewModel();
            _persons = _pvm.Persons;
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

        public void AddPerson(Model.Person1 person)
        {
            _pvm.Add(person);
        }

        private void OnPropertyChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
