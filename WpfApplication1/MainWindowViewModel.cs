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
using System.Data.SqlClient;

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

        //public static void PlayStat(string name, DateTime time, string team)
        //{
        //    using (SqlConnection cn = new SqlConnection("Server=GRISHA-PC\\SQLEXPRESS; Database = myDataBase; Trusted_Connection = True;"))
        //    {
        //        cn.Open();
        //        string sql = string.Format("INSERT INTO Players(name, time, team) values ('{0}','{1}','{2}')", name, time, team);
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cmd.ExecuteNonQuery();

        //    }
        //}

            

        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public void CheckScore()
        {
            scoreHome = 0;
            scoreGuest = 0;
            foreach (var item in goal)
            {
                if (item._selectedTeam == item.team[0])
                {
                    scoreHome++;
                }
                if (item._selectedTeam == item.team[1])
                {
                    scoreGuest++;
                }
            }
            result = $"{scoreHome}:{scoreGuest}";
        }
    }
}

