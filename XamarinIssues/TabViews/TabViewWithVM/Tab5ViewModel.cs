using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class Tab5ViewModel : TabViewModel
    {
        public override string Title => "Tab 5";
        public override DataTemplate ContentTemplate { get; } = new DataTemplate(() => new Tab5View());
    }
}