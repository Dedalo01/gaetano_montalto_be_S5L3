namespace eserL5S3.Models
{
    public class Item
    {
        private int _id;
        private double _price;
        private string _name;
        private string _description;
        //private List<string> _imageUrls = new List<string>(3);
        private string[] _imageUrls = new string[3];
        private string notFoundImg = "https://salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled-1150x647.png";

        public int Id { get { return _id; } }
        public double Price { get { return _price; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        //public List<string> ImageUrls { get { return _imageUrls; } }
        public string[] ImageUrls { get { return _imageUrls; } }


        public Item(int id, double price, string name, string description)
        {
            _id = id;
            _price = price;
            _name = name;
            _description = description;

            for (int i = 0; i < _imageUrls.Length; i++) { _imageUrls[i] = notFoundImg; }
        }

        public Item(int id, double price, string name, string description, string[] imageUrls)
        {
            _id = id;
            _price = price;
            _name = name;
            _description = description;
            _imageUrls = imageUrls;
        }

        public void AddMainImageUrl(string imageUrl)
        {
            _imageUrls[0] = imageUrl;
        }

        public void AddSecondaryImageUrl(string imageUrl)
        {
            _imageUrls[1] = imageUrl;
        }

        public void AddTertiaryImageUrl(string imageUrl)
        {
            _imageUrls[2] = imageUrl;
        }

        //public void AddImageUrl(string imageUrl)
        //{
        //    _imageUrls.Add(imageUrl);
        //}

    }
}
