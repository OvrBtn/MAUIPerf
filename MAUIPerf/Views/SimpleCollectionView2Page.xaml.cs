using MAUIPerf.ViewModels;
namespace MAUIPerf
{
    public partial class SimpleCollectionView2Page : ContentPage
    {
        public SimpleCollectionView2Page()
        {
            InitializeComponent();
            BindingContext = new SimpleCollectionView1ViewModel();
        }
    }
}
