using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public MainViewModel() 
        {

        }

        private double firstval;
        
        public double FirstVal
        {
            get { return firstval; }
            set {
                
                firstval = value;
                OnPropertyChanged();
                Result = FirstVal + SecondVal;

            }
        }
        
        private double secondval;

        public double SecondVal
        {
            get { return secondval; }
            set {
                
                secondval = value;
                OnPropertyChanged();
                
                Result = FirstVal + SecondVal;
                               
                
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }

       

    }
}
