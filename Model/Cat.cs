namespace Prac.Model.Category;
public record Item
{
    public string Key = Guid.NewGuid().ToString();
    public string Name = null; // "Hi-Potion", "Potion", "Mana-Potion", "Sword Lv2"
}
