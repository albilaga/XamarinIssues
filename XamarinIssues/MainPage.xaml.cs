using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinIssues.TabViews;

namespace XamarinIssues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TabViewOnXamlClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTabPage());
        }
        
        private void TabViewOnCsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTabCreatePage());
        }
    }
}