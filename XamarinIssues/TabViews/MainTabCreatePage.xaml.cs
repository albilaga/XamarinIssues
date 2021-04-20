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
            TabView.TabItems.Add(new Tab1View());
            TabView.TabItems.Add(new Tab2View());
            TabView.TabItems.Add(new Tab3View());
            TabView.TabItems.Add(new Tab4View());
            TabView.TabItems.Add(new Tab5View());
        }
    }
}