using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using LinqToVisualTree;

namespace CoverFlow.View
{
    public partial class CoverFlowItemView
    {
        public CoverFlowItemView()
        {
            InitializeComponent();
        }

        // Dependency property used to bind the state of the VisualStateManager to a viewmodel property
        public static readonly DependencyProperty VisualStateProperty = DependencyProperty.RegisterAttached("VisualState",
            typeof(string), typeof(CoverFlowItemView), new PropertyMetadata(VisualStateChanged));

        public static string GetVisualState(DependencyObject target)
        {
            return (string)target.GetValue(VisualStateProperty);
        }

        public static void SetVisualState(DependencyObject target, string value)
        {
            target.SetValue(VisualStateProperty, value);
        }

        private static void VisualStateChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            var newState = (string)args.NewValue;
            if (!string.IsNullOrWhiteSpace(newState))
            {
                // Set the ZIndex based on the visual state.  This needs to be set on the ContentPresenter.
                var control = (Control)sender;
                var container = (ContentPresenter)control.Ancestors<ContentPresenter>().Single();
                Canvas.SetZIndex(container, ZIndexFromVisualState(newState));

                VisualStateManager.GoToState(control, newState, true);
            }
        }

        private static int ZIndexFromVisualState(string visualState)
        {
            switch (visualState)
            {
                case "Left_2":
                    return 1;

                case "Left_1":
                    return 2;

                case "Current":
                    return 3;

                case "Right_1":
                    return 2;

                case "Right_2":
                    return 1;

                default:
                    return 0;
            }
        }
    }
}
