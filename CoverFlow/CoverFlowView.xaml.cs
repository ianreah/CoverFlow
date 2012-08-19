using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using CoverFlow.ViewModel;
using System.ComponentModel;
using System.Windows.Browser;

namespace CoverFlow
{
    public partial class CoverFlowView
    {
        private CoverFlowViewModel viewModel;
        private readonly StoryboardFactory storyboardFactory = new StoryboardFactory();

        public CoverFlowView()
        {
            InitializeComponent();
        }

        private void CoverFlowView_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = new CoverFlowViewModel();
            viewModel.PropertyChanged += ViewModelPropertyChanged;
            DataContext = viewModel;

            // TODO: Bind this to a user input in the UI?
            viewModel.Username = "ianreah";

            HtmlPage.Plugin.Focus();
        }

        void ViewModelPropertyChanged(object sender, PropertyChangedEventArgs eventArgs)
        {
            if (eventArgs.PropertyName == "CurrentItemIndex")
            {
                Animate();
            }
        }

        private void Animate()
        {
            var storyboard = storyboardFactory.CreateStoryboard(viewModel.CurrentPosition, itemsContainer);
            storyboard.Begin();
        }

        private void CoverFlowView_KeyDown(object sender, KeyEventArgs e)
        {
            if (viewModel == null)
            {
                return;
            }

            if (e.Key == Key.Right)
            {
                viewModel.NextItem();
                e.Handled = true;
            }

            if (e.Key == Key.Left)
            {
                viewModel.PreviousItem();
                e.Handled = true;
            }
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Animate();
        }
    }
}
