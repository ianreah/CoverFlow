using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace CoverFlow.ViewModel
{
    public class CoverFlowItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly lfmTopalbumsAlbum lfmAlbum;

        public CoverFlowItemViewModel(lfmTopalbumsAlbum lfmAlbum)
        {
            this.lfmAlbum = lfmAlbum;
        }

        public string Url { get { return lfmAlbum.url; } }
        public string Image { get { return lfmAlbum.image[3].Value; } }

        private string visualState = "Hidden";
        public string VisualState
        {
            get { return visualState; }
            set
            {
                if (VisualState == value)
                {
                    return;
                }

                visualState = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("VisualState"));
                }
            }
        }
    }
}
