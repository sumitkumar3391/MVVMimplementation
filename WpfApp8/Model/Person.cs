using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace WpfApp8.Model
{
    public class Person : INotifyPropertyChanged
    {
        public string _fname;
        public string _lname;
        public int _number;
        public  string Firstname
        {
            get { return _fname; }
            set { _fname = value; ONPropertChanged("Firstname"); }
        }
        public  string Lastname
        {
            get { return _lname; }
            set { _lname = value; ONPropertChanged("Lastname"); }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value;  ONPropertChanged("Number"); }
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
