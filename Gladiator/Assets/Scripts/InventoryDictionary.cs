using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDictionary : MonoBehaviour
{
    public Hashtable Inventory = new Hashtable(); // This should make a dictionary for the inventory to store stuff
    // This should be accessible throughout the game, so when the main
    // character gets items, it goes here


    // Start is called before the first frame update
    void Start()
    {
	Debug.Log("Inventory dictionary made");	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
