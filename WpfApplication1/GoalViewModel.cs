using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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
    }
}
