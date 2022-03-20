using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NotepadV2__.ViewModels
{
    public class HelpViewModel
    {
        public ICommand HelpCommand { get; }



        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DispalyAbout);
        }

        private void DispalyAbout()
        {
            HelpDialog helpDialog = new HelpDialog();
            helpDialog.Show();
        }

    }
}
