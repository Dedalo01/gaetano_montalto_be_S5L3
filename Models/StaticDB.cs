namespace eserL5S3.Models
{
    public class StaticDB
    {
        private static int _id = 0;

        private static List<Item> _items = [
            new Item(_id, 154.3, "Nike Iria", "Ecco l'ultimo modello di scarpe nike, che aspetti?? Comprale!"),
            new Item(++_id, 50.32, "Rich Shoes", "Le scarpe preferite dei ricconi!"),
            new Item(++_id, 323.08, "Toyota Runners", "Solo per veri intenditori!"),
        ];

        public static List<Item> Items { get { return _items; } }

        public static Item? GetItemById(int id) { return _items[id]; }

        public static Item AddItem(double price, string name, string description)
        {
            _id++;
            Item item = new Item(_id, price, name, description);
            _items.Add(item);

            return item;
        }

        public static Item? HardDeleteItem(int id)
        {

            Item deletedItem = _items[id];
            if (deletedItem != null)
            {
                _items.RemoveAt(id);
                return deletedItem;
            }

            return null;
        }
    }
}
