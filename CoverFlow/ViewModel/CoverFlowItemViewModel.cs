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

		private readonly string url;
		private readonly string image;

        public CoverFlowItemViewModel(string url, string image)
        {
	        this.url = url;
	        this.image = image;
        }

	    public string Url { get { return url; } }
        public string Image { get { return image; } }

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
