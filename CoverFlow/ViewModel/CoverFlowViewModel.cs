using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.Windows;

namespace CoverFlow.ViewModel
{
    public class CoverFlowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<CoverFlowItemViewModel> coverFlowItems = new ObservableCollection<CoverFlowItemViewModel>();
        private int currentItemIndex = -1;
        private string username = string.Empty;

        private readonly WebClient webClient = new WebClient();

        public CoverFlowViewModel()
        {
            webClient.DownloadStringCompleted += (s, e) => CreateItemsFromXml(e.Result);
        }

        public ObservableCollection<CoverFlowItemViewModel> CoverFlowItems
        {
            get { return coverFlowItems; }
            set
            {
                if (coverFlowItems != value)
                {
                    coverFlowItems = value;
                    RaisePropertyChanged("CoverFlowItems");
                }
            }
        }

        public int CurrentItemIndex
        {
            get { return currentItemIndex; }
            private set
            {
                if (currentItemIndex != value && IsValidIndex(value))
                {
                    currentItemIndex = value;
                    RaisePropertyChanged("CurrentItemIndex");
                }
            }
        }

        public int CurrentPosition
        {
            get { return -(CurrentItemIndex-2) * (int)Application.Current.Resources["ItemSize"]; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;

                    RaisePropertyChanged("Username");
                    FetchDataAsync();
                }
            }
        }

        private bool IsValidIndex(int value)
        {
            return value >= 0 && value < CoverFlowItems.Count;
        }

        private void FetchDataAsync()
        {
            // To fetch the 50 top albums for any last.fm user...
            //      + Replace the code in this method with the following code
            //      + Paste in your last.fm api key (http://www.last.fm/api/account)
            //      + Bind Username to user input
            /* 
            var query = string.Format(@"http://ws.audioscrobbler.com/2.0/?method=user.gettopalbums&user={0}&api_key={1}&period=overall", Username, INSERT-YOUR-LASTFM-API-KEY-HERE);
            webClient.DownloadStringAsync(new Uri(query));
            */

            // Otherwise just use the cached result from the above last.fm query
            var cachedXml = Resources.ResourceManager.GetString("CachedLastFmQueryXml");
            if (cachedXml != null)
            {
                CreateItemsFromXml(cachedXml);
            }
        }

        public void NextItem()
        {
            SetItemVisualState(CurrentItemIndex - 2, "Hidden");
            SetItemVisualState(CurrentItemIndex - 1, "Left_2");
            SetItemVisualState(CurrentItemIndex, "Left_1");
            SetItemVisualState(CurrentItemIndex + 1, "Current");
            SetItemVisualState(CurrentItemIndex + 2, "Right_1");
            SetItemVisualState(CurrentItemIndex + 3, "Right_2");

            CurrentItemIndex++;
        }

        public void PreviousItem()
        {
            SetItemVisualState(CurrentItemIndex - 3, "Left_2");
            SetItemVisualState(CurrentItemIndex - 2, "Left_1");
            SetItemVisualState(CurrentItemIndex - 1, "Current");
            SetItemVisualState(CurrentItemIndex, "Right_1");
            SetItemVisualState(CurrentItemIndex + 1, "Right_2");
            SetItemVisualState(CurrentItemIndex + 2, "Hidden");

            CurrentItemIndex--;
        }

        private void SetItemVisualState(int itemIndex, string visualState)
        {
            if (IsValidIndex(itemIndex))
            {
                CoverFlowItems[itemIndex].VisualState = visualState;
            }
        }

        private void CreateItemsFromXml(string result)
        {
            var xmlSerializer = new XmlSerializer(typeof(lfm));

            var dataFetchResult = (lfm)xmlSerializer.Deserialize(new System.IO.StringReader(result));

            if (dataFetchResult != null && dataFetchResult.status == "ok"
                && dataFetchResult.topalbums != null && dataFetchResult.topalbums.Length > 0
                && dataFetchResult.topalbums[0] != null)
            {
                var results = dataFetchResult.topalbums[0].album;
                CoverFlowItems = new ObservableCollection<CoverFlowItemViewModel>(results.Select(r => new CoverFlowItemViewModel(r)));
                CurrentItemIndex = 1;
                NextItem();
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
