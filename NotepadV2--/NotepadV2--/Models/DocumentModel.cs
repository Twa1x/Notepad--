using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadV2__.Models
{
    public class DocumentModel : ObservableObject
    {
        private string _text;
        private string _filePath;
        private string _fileName;
        private bool _isSaved;
        private bool _textChanged;
      

        public bool TextChanged
        {
            get { return _textChanged; }
            set { OnPropertyChanged(ref _textChanged, value);  } // trimitem ref de la _text 

        }
        public string Text
        {
            get { return _text; }
            set { OnPropertyChanged(ref _text, value);} // trimitem ref de la _text 

        }

        public string FilePath
        {
            get { return _filePath; }
            set { OnPropertyChanged(ref _filePath, value); } // trimitem ref de la _filePath 
        }

        public string FileName
        {
            get { return _fileName; }
            set { OnPropertyChanged(ref _fileName, value); } // trimitem ref de la _fileName 
        }

        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                    return true;
                return false;
            }
        }

        public bool IsSaved
        {   
            get { return _isSaved; }
            set { OnPropertyChanged(ref _isSaved, value); }
        }
    }
}
