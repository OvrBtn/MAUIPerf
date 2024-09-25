using MAUIPerf.ViewModels;

namespace MAUIPerf
{
    public partial class CollectionView2Page : ContentPage
    {
        public CollectionView2Page()
        {
            InitializeComponent();
            BindingContext = new CollectionView2ViewModel();
        }
    }
}
