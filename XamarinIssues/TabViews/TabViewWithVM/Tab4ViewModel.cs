using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class Tab4ViewModel : TabViewModel
    {
        public override string Title => "Tab 4";
        public override DataTemplate ContentTemplate { get; } = new DataTemplate(() => new LazyView<Tab4View>());
    }
}