using NotepadV2__.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace NotepadV2__.ViewModels
{
    public class FindViewModel
    {


        public ICommand FindCommand { get; }

        public ICommand ReplaceAllCommand { get; }

        public FindModel Word { get; set; }
        public DocumentModel Document { get; set; }
        public FindViewModel(DocumentModel document)
        {
            Document = document;
            FindCommand = new RelayCommand(Find);
            ReplaceAllCommand = new RelayCommand(ReplaceAll);
        }


        private void Find()
        {
            string word = string.Empty;
            InputDialog inputDialog = new InputDialog("Please enter the word you are looking for: ");
            if (inputDialog.ShowDialog() == true)
                word = inputDialog.Answer;


            if (Document.Text.Contains(word))
            {
                Console.WriteLine("Da");
               
            }
            else
            {
                Console.WriteLine("Nu");
            }
        }

        private void ReplaceAll()
        {
            string word = string.Empty;
            InputDialog inputDialog = new InputDialog("Please enter the word you want to replace: ");
            if (inputDialog.ShowDialog() == true)
                word = inputDialog.Answer;
            Document.Text.Replace(word, "alex");
        }

    }
}
