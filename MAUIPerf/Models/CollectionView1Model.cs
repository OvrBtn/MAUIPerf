namespace MAUIPerf.Models
{
    public class CollectionView1Model
    {
        static Random random = new();
        public List<ChildItem> ChildItems { get; set; } = new();
        public int ItemNumber { get; set; }
        public Color Color { get; set; } = Colors.Aqua;
        public CollectionView1Model(int itemNumber)
        {
            ItemNumber = itemNumber;
            int randomNumber = random.Next() % 5;
            for (int i = 0; i < randomNumber; i++)
            {
                ChildItems.Add(new(random.Next() % 1000));
            }
        }
    }


}
