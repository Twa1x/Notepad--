using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NotepadV2__
{
    /// <summary>
    /// Interaction logic for InputDialogReplaceIndex.xaml
    /// </summary>
    public partial class InputDialogReplaceIndex : Window
    {
        public InputDialogReplaceIndex(string question, string question2,string question3, string defaultAnswer = "", string defaultAnswer2 = "", string defaultAnswer3= "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            lblQuestion2.Content = question2;
            lblQuestion3.Content = question3;
            txtAnswer.Text = defaultAnswer;
            txtAnswer2.Text = defaultAnswer2;
            txtAnswer3.Text = defaultAnswer3;
        }
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }

        public string Answer2
        {
            get { return txtAnswer2.Text; }
        }
        public string Answer3
        {
            get { return txtAnswer3.Text; }
        }
    }
}
