using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class GoalCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var addGoal = parameter as MainWindowViewModel;
            if (addGoal == null)
                throw new ArgumentNullException("Модель представления не может быть null");
            addGoal.fillGoal();
        }

        public event EventHandler CanExecuteChanged;
    }
}
