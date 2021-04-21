namespace XamarinIssues.TabViews.TabViewWithVM
{
    public partial class MainTabWithVm
    {
        public MainTabWithVm()
        {
            InitializeComponent();
            BindingContext = new MainTabWithVmViewModel();
        }
    }
}