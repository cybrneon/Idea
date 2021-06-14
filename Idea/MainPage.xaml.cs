using Idea.Pages;
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


namespace Idea
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            //string appName = Windows.ApplicationModel.Package.Current.DisplayName;

        }

        private void AppNavigation_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(TodayPage));
        }

        private void AppNavigation_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                contentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "TodayPageTag":
                        contentFrame.Navigate(typeof(TodayPage));
                        break;

                    case "ImportantPageTag":
                        contentFrame.Navigate(typeof(ImportantPage));
                        AppNavigation.Header = "Important";
                        break;

                    case "UpcomingPageTag":
                        contentFrame.Navigate(typeof(UpcomingPage));
                        AppNavigation.Header = "Upcoming";
                        break;

                    case "LogBookPageTag":
                        contentFrame.Navigate(typeof(LogBookPage));
                        AppNavigation.Header = "Log Book";
                        break;
                }
            }
        }

        private void SearchTasks_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //do something
            }
        }
    }
}
