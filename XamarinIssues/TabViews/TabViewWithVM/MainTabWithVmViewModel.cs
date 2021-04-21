using System.Collections.Generic;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class MainTabWithVmViewModel : ObservableObject
    {
        public List<TabViewModel> TabViewModels => new List<TabViewModel>
        {
            new Tab1ViewModel(),
            new Tab2ViewModel(),
            new Tab3ViewModel(),
            new Tab4ViewModel(),
            new Tab5ViewModel()
        };
    }
}