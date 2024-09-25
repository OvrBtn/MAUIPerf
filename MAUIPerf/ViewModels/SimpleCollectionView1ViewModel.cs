using MAUIPerf.Models;

namespace MAUIPerf.ViewModels
{
    internal class SimpleCollectionView1ViewModel
    {
        public List<CollectionView1Model> Items { get; set; } = new();
        public SimpleCollectionView1ViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new(i));
            }
        }
    }
}
