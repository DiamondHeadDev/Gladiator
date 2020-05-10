using SQLite4Unity3d;

public class Weapon
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
}
