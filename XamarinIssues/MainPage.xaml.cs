using System;
using XamarinIssues.TabViews;
using XamarinIssues.TabViews.TabViewWithVM;

namespace XamarinIssues
{
    public partial class MainPage
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

        private void TabViewWithItemSourceClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTabWithVm());
        }
    }
}