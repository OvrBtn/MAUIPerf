using MAUIPerf.Models;

namespace MAUIPerf.ViewModels
{
    internal class CollectionView2ViewModel
    {
        public List<CollectionView1Model> Items { get; set; } = new();
        public bool IsEditingEnabled { get; set; } = false;
        public CollectionView2ViewModel()
        {
            for (int i = 0; i < 500; i++)
            {
                Items.Add(new(i));
            }
        }
    }
}
