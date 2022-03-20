using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NotepadV2__.Models
{
    public class FormatModel : ObservableObject
    {
        private FontStyle _style;
        private FontWeight _weight;
        private FontFamily _family;
        private TextWrapping _wrap;
        private bool _isWrapped;
        private double _size;

        public FontStyle Style
        { 
            get { return _style; }
            set { OnPropertyChanged(ref _style, value); }
        }

        public FontWeight Weight
        {
            get { return _weight; }
            set { OnPropertyChanged(ref _weight, value); }
        }

        public FontFamily Family
        {
            get { return _family; }
            set { OnPropertyChanged(ref _family, value); }
        }

        public TextWrapping Wrap
        {
            get { return _wrap; }
            set 
            {
                OnPropertyChanged(ref _wrap, value);
               
                if (value == TextWrapping.Wrap)
                    isWrapped = true;
                else
                    isWrapped = false;
            }

        }

        public bool isWrapped
        {

            get { return _isWrapped; }
            set { OnPropertyChanged(ref _isWrapped, value); }
        }

        public double Size
        {
            get { return _size; }
            set { OnPropertyChanged(ref _size, value); }
        }

    }
}

