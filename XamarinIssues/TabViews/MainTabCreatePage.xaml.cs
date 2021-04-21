using Xamarin.CommunityToolkit.UI.Views;

namespace XamarinIssues.TabViews
{
    public partial class MainTabCreatePage
    {
        public MainTabCreatePage()
        {
            InitializeComponent();
            // TabView.TabItems.Add(new Tab1View());
            // TabView.TabItems.Add(new Tab2View());
            // TabView.TabItems.Add(new Tab3View());
            // TabView.TabItems.Add(new Tab4View());
            // TabView.TabItems.Add(new Tab5View());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TabView.TabItems.Add(new TabViewItem
            {
                Text = "Tab 1",
                Content = new Tab1View()
            });
            TabView.TabItems.Add(new TabViewItem
            {
                Text = "Tab 2",
                Content = new LazyView<Tab2View>()
            });
            TabView.TabItems.Add(new TabViewItem
            {
                Text = "Tab 3",
                Content = new Tab3View()
            });
            TabView.TabItems.Add(new TabViewItem
            {
                Text = "Tab 4",
                Content = new LazyView<Tab4View>()
            });
            TabView.TabItems.Add(new TabViewItem
            {
                Text = "Tab 5",
                Content = new Tab5View()
            });
        }
    }
}