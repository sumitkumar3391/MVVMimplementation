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
     public class DepartmentViewModel1 : INotifyPropertyChanged
    {
         private ObservableCollection<Deaprtment1> _departments;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Deaprtment1> Departments
        {
            get { return _departments; }
            set
            {
                _departments = value;
                ONPropertChanged("Departments");
            }
        }
        public DepartmentViewModel1()
        {
            _departments = new ObservableCollection<Deaprtment1>();
        }
        public void add1( Deaprtment1 deaprtment)
        {
            _departments.Add(deaprtment);

        }
        private void ONPropertChanged(string parameter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
