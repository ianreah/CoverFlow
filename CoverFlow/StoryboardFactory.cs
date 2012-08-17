using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Windows;

namespace CoverFlow
{
    class StoryboardFactory
    {
        public Storyboard CreateStoryboard(int position, ItemsControl itemsContainer)
        {
            var result = new Storyboard();

            var itemSize = (int)Application.Current.Resources["ItemSize"];
            var outerPanel = (Panel)itemsContainer.Parent;

            var animation = new DoubleAnimation { To = position-(itemSize/2)+(outerPanel.ActualWidth/2), Duration = new Duration(TimeSpan.FromSeconds(0.5)), EasingFunction = new CubicEase { EasingMode = EasingMode.EaseInOut } };

            Storyboard.SetTarget(animation, itemsContainer);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(Canvas.Left)"));

            result.Children.Add(animation);
            return result;
        }
    }
}
