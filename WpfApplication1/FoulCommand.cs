using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class FoulCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var AddFoul = parameter as MainWindowViewModel;
            if (AddFoul == null)
                throw new ArgumentNullException("Модель представления не может быть null");

            AddFoul.fillFoul();
        }

        public event EventHandler CanExecuteChanged;
    }
}
