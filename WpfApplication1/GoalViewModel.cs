using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Data.SqlClient;

namespace WpfApplication1
{
    public class GoalViewModel : INotifyPropertyChanged
    {
        public String time { get; set; }
        public List<string> team { get; set; }
        public string selectedTeam;
        public String _selectedTeam
        {
            get { return selectedTeam; }
            set { selectedTeam = value; DoPropertyChanged("_selectedTeam"); }
        }
        public List<string> player { get; set; }
        public String _selectedPlayer { get; set; }
        public GoalViewModel()
        {
            player = new List<string>()
            {
                "Александр Самедов",

                "Куинси Промес",

                "Евгений Макеев",

                "Дмитрий Комбаров",

                "Артём Ребров",

                "Денис Глушаков",

                "Егор Титов",

                "Ведран Чорлука",

                "Дмитрий Тарасов",

                "Дмитрий Лоськов",

                "Ари",

                "Игорь Денисов",

                "Алан Касаев",
            };
            team = new List<string>()
            {
                "Спартак Москва",
                "Локомотив Москва",
            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => PlayStat(_selectedPlayer, time, selectedTeam), _canExecute));

            }
        }
       
        public static void PlayStat(string player, string time, string team)
        {
            using (SqlConnection cn = new SqlConnection("Server=GRISHA-PC\\SQLEXPRESS; Database = myDataBase; Trusted_Connection = True;"))
            {
                cn.Open();
                string sql = string.Format("INSERT INTO Table(name, time, team) values ('{0}','{1}','{2}')", player, time, team);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();

            }
        }
        private bool _canExecute;
    }

    public class CommandHandler : ICommand
    {
        private Action _action;
        private bool _canExecute;
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }

    }
}
