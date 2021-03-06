﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Xbmc2S.RT.Search
{
    public sealed partial class GlobalSearchBox : UserControl
    {

        public GlobalSearchBox()
        {
            this.InitializeComponent();
            Window.Current.SizeChanged += WindowSizeChanged;
            AdaptWindowSize();
        }

        private void WindowSizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            AdaptWindowSize();
        }

        private void AdaptWindowSize()
        {
            if (Window.Current.Bounds.Width < 768)
            {
                Visibility = Visibility.Collapsed;
            }
            else
            {
                Visibility = Visibility.Visible;
            }
        }



        public bool FocusOnKeyboardInput
        {
            get { return false; }
            set {  }
        }

        private void FlyoutBase_OnOpening(object sender, object e)
        {
            var flyout = (Flyout)sender;
            App.MainVm.RemoteControl.Refresh();
            ((FrameworkElement)flyout.Content).DataContext = App.MainVm.RemoteControl;
        }
    }
}
