using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class FoulViewModel
    {
        public String timeoffoul { get; set; }
        public List<String> player { get; set; }
        public String _selectedPlayer { get; set; }
        public List<String> fouls { get; set; }
        public String _selectedFoul { get; set; }
        public List<String> punishment { get; set; }
        public String _selectedPunishment { get; set; }
        public FoulViewModel()
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
            fouls = new List<string>()
            {

                "Подкат",
                "Игра рукой",
                "Фол последней надежды",
                "Плевок",
                "Симуляция",
                "Толчок"
            };
            punishment = new List<string>()
            {

                "Красная карточка",
                "Жёлтая карточка"
            };
        }
    }
}
