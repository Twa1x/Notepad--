using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace NotepadV2__.ViewModels
{
    public class CustomMessageBox
    {
        public CustomMessageBox()
        {
            Window w = new Window();
            DockPanel panel = new DockPanel();
            TextBlock tx = new TextBlock();
            Paragraph parx = new Paragraph();
            Run run3 = new Run("Google");
            Hyperlink hyperl = new Hyperlink(run3);
            hyperl.NavigateUri = new Uri("https://www.google.ro/");
            tx.Inlines.Add(hyperl);
            panel.Children.Add(tx);
            w.Content = panel;
            w.Show();
        }
    }
}
