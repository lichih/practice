namespace Prac.Model
{
    [Serializable]
    public record Player
    {
        public string Key = Guid.NewGuid().ToString();
        public string Name = null; // "Player 1", "Player 2", "Player 3", "Player 4"
        public List<Item> Items = new List<Item>();
        public int Gold = 0;
    }

    public record Item
    {
        public string Key = Guid.NewGuid().ToString();
        public string Type = null; // Consumable, Equipment, Weapon, Armor, etc. 
        public string ItemKey = null;
    }
}
