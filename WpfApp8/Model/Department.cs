using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp8.Model
{
     public class Department:INotifyPropertyChanged
    {
        public int _deptid;
        public string _deptname;
        public int _salary;

        public int DeptID
        {
            get { return _deptid; }
            set { _deptid = value;ONPropertChanged("DeptID"); }
        }
        public string Deptname
        {
            get { return _deptname; }
            set { _deptname = value; ONPropertChanged("Deptname"); }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value;  ONPropertChanged("Salary"); }
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
