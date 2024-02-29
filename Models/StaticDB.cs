namespace eserL5S3.Models
{
    public static class StaticDB
    {
        // CAMPI
        private static int _id = 0;

        private static List<Item> _items = [
            new Item(_id, 154.3, "Nike Iria", "Ecco l'ultimo modello di scarpe nike, che aspetti?? Comprale!"),
            new Item(++_id, 50.32, "Rich Shoes", "Le scarpe preferite dei ricconi!"),
            new Item(++_id, 323.08, "Toyota Runners", "Solo per veri intenditori!"),
        ];

        // PROPRIETA'
        public static List<Item> Items { get { return _items; } }

        // METODI

        // GET ITEM BY id 
        public static Item? GetItemById(int id) { return _items[id]; }

        // ADD ITEM
        public static Item AddItem(double price, string name, string description)
        {
            _id++;
            Item item = new Item(_id, price, name, description);
            _items.Add(item);

            return item;
        }

        // DELETE ITEM definitivamente
        public static Item? HardDeleteItem(int id)
        {
            Item? itemFound = StaticDB.Items.Find(item => item.Id == id);

            if (itemFound != null)
            {
                StaticDB.Items.Remove(itemFound);
                return itemFound;
            }
            return null;
        }

        // UPDATE ITEM
        public static Item? UpdateItem(Item item)
        {
            int itemFoundIndex = StaticDB.Items.FindIndex(existingItem => existingItem.Id == item.Id);

            if (itemFoundIndex != -1)
            {
                Items[itemFoundIndex].Name = item.Name;
                Items[itemFoundIndex].Price = item.Price;
                Items[itemFoundIndex].Description = item.Description;

                return Items[itemFoundIndex];
            }

            return null;
        }

        // SOFT DELETE
        public static Item? SoftDeleteItem(int id)
        {
            Item? softDeletedItem = Items.Find(item => id == item.Id);
            if (softDeletedItem != null)
            {
                Items[softDeletedItem.Id].DeletedAt = DateTime.UtcNow;

                return softDeletedItem;
            }

            return null;
        }
    }
}
