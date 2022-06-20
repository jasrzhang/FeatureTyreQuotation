using System;

using FeatureTyreQuotation.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FeatureTyreQuotation.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
