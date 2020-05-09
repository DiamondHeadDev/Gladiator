using UnityEngine;

// This should be accessable anywhere within the game. You should be able to make items as an item class

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;
}
