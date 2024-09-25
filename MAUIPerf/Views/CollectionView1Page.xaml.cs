using MAUIPerf.ViewModels;

namespace MAUIPerf
{
    public partial class CollectionView1Page : ContentPage
    {
        public CollectionView1Page()
        {
            InitializeComponent();
            BindingContext = new CollectionView1ViewModel();
        }
    }
}
