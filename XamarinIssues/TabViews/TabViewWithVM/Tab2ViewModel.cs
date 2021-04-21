using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class Tab2ViewModel : TabViewModel
    {
        public override string Title => "Tab 2";
        public override DataTemplate ContentTemplate { get; } = new DataTemplate(() => new LazyView<Tab2View>());
    }
}