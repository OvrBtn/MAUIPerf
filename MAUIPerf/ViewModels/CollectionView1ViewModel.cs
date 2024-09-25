using MAUIPerf.Models;

namespace MAUIPerf.ViewModels
{
    internal class CollectionView1ViewModel
    {
        public List<CollectionView1Model> Items { get; set; } = new();
        public CollectionView1ViewModel()
        {
            for (int i = 0; i < 500; i++)
            {
                Items.Add(new(i));
            }
        }
    }
}
