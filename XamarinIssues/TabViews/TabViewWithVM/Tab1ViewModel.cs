using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class Tab1ViewModel : TabViewModel
    {
        public override string Title => "Tab 1";
        public override DataTemplate ContentTemplate { get; } = new DataTemplate(() => new Tab1View());
    }
}