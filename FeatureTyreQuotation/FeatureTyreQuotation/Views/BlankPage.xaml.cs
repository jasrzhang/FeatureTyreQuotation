using System;

using FeatureTyreQuotation.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FeatureTyreQuotation.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
