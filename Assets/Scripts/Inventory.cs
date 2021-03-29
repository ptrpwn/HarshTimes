using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;
    public UIItem useItem;
    public Item item;
    bool inventoryOpen = false;


    //Add item with ID
    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddItem(itemToAdd);
        Debug.Log("Added Item (ID): " + itemToAdd.id);
    }

    //Add item with Name
    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddItem(itemToAdd);
        Debug.Log("Added Item (title): " + itemToAdd.title);
    }

    //Check if player has item in inventory
    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }
    
    //Remove item from inventory
    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Item removed: " + itemToRemove.title);
        }
    }

    //Check if add to/remove from inventory works
    private void Start()
    {
        inventoryUI.gameObject.SetActive(false);
        GiveItem("Spitzhacke");
        GiveItem(1);
        //RemoveItem(1);
    }

    //Open & close inventory
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
            if (!inventoryOpen)
            {
                inventoryOpen = true;
            }
            else
            {
                inventoryOpen = false;
            }
        }
    }
}
