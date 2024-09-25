using MAUIPerf.ViewModels;
namespace MAUIPerf
{
    public partial class SimpleCollectionView1Page : ContentPage
    {
        public SimpleCollectionView1Page()
        {
            InitializeComponent();
            BindingContext = new SimpleCollectionView1ViewModel();
        }
    }
}
