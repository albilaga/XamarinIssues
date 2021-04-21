using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public abstract class TabViewModel : ObservableObject
    {
        public abstract string Title { get; }
        public abstract DataTemplate ContentTemplate { get; }
    }
}