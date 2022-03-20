using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadV2__.Models
{
   public class FindModel : ObservableObject
    {
       
        private string _word;


        public string Word
        {
            get { return _word; }
            set { OnPropertyChanged(ref _word, value); }
        }

    }
}
