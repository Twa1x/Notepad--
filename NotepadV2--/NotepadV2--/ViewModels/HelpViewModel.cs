using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NotepadV2__.ViewModels
{
    public class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DispalyAbout);
        }

        private void DispalyAbout()
        {
            CustomMessageBox message = new CustomMessageBox();
        }

    }
}
