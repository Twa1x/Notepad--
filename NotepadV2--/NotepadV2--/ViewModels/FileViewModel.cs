﻿using Microsoft.Win32;
using NotepadV2__.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NotepadV2__.ViewModels
{
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

        //Toolbar
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand ExitCommand { get; }

        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
            ExitCommand = new RelayCommand(ExitFile);
        }

        public void NewFile()
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;
        }

        private void SaveFile()
        {
            if (Document.IsSaved == true)
            {
                File.WriteAllText(Document.FilePath, Document.Text);
                Document.TextChanged = false;
            }
            else
                SaveFileAs();
        }
            
        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
                Document.TextChanged = false;
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
          //openFileDialog.Filter = "Text File (*.txt)|*.txt | All files (*.*)|*.*";
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void ExitFile()
        {
            if (MessageBox.Show(string.Format("Are you sure you want to exit Notepad--?"), "Close Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SaveFile();
                System.Windows.Application.Current.Shutdown();
            }

        }
        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
            Document.IsSaved = true;
        }


    }
}
