namespace MAUIPerf.Models
{
    public class CollectionView2Model
    {
        public int ItemNumber { get; set; }
        public Color BackgroundColor { get; set; } = Colors.Aqua;

        public CollectionView2Model(int itemNumber)
        {
            ItemNumber = itemNumber;
        }
    }
}
