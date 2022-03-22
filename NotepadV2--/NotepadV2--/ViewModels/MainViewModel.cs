using NotepadV2__.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadV2__.ViewModels
{
    public class MainViewModel
    {
        //private List<DocumentModel> _documents;
        private DocumentModel _document;



        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }

        public FindViewModel Find { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            File = new FileViewModel(_document);
            Find = new FindViewModel(_document);

        }


    }
}
