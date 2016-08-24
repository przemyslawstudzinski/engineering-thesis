﻿using ApplicationToSupportAndControlDiet.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ApplicationToSupportAndControlDiet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen = this.MySplitView.IsPaneOpen ? false : true;
        }
       
        private void HomePaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "CONTROL DIET";
            this.WorkSpace.Navigate(typeof(CalendarPage));
        }

        private void AddMealPaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "ADD MEAL";
        }
        private void SearchPaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "SEARCH";
        }
        private void ProfilePaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "YOUR PROFILE";
            WorkSpace.Navigate(typeof(YourProfile));
        }
        private void AddNewProductPaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "ADD NEW PRODUCT";
            WorkSpace.Navigate(typeof(AddNewProduct));
        }
        private void SettingsPaneItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationName.Text = "SETTINGS";
        }
        public void SelectedDay_Click(object sender, RoutedEventArgs e)
        {
            this.WorkSpace.Navigate(typeof(CalendarPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
