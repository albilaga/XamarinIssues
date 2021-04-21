using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class Tab3ViewModel : TabViewModel
    {
        public override string Title => "Tab 3";
        public override DataTemplate ContentTemplate { get; } = new DataTemplate(() => new Tab3View());
    }
}