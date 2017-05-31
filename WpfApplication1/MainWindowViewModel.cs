using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Input;




namespace WpfApplication1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<GoalViewModel> goal { get; set; }

        public void fillGoal()
        {
            goal.Add(new GoalViewModel() { });
        }

        public ObservableCollection<FoulViewModel> fouls { get; set; }

        public void fillFoul()
        {
            fouls.Add(new FoulViewModel() { });
        }
        public Int32 scoreHome { get; set; }
        public Int32 scoreGuest { get; set; }
        private string _result;
        public string result
        {
            get { return _result; }
            set
            {
                _result = value;
                DoPropertyChanged("result");
            }
        }
        public ICommand AddGoalButton { get; set; }
        public ICommand AddFoulButton { get; set; }
        public MainWindowViewModel()
        {
            goal = new ObservableCollection<GoalViewModel>();
            fouls = new ObservableCollection<FoulViewModel>();
            AddGoalButton = new GoalCommand();
            AddFoulButton = new FoulCommand();
            scoreHome = 0;
            scoreGuest = 0;
            result = $"{scoreHome}:{scoreGuest}";

        }





        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}

