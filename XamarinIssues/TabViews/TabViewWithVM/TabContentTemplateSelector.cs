using Xamarin.Forms;

namespace XamarinIssues.TabViews.TabViewWithVM
{
    public class TabContentTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TabViewModel viewModel)
            {
                return viewModel.ContentTemplate;
            }

            return null;
        }
    }
}