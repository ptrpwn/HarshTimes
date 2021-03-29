using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 16;

    //Add slots to inventory
    private void Awake()
    {
        for(int i=0; i<numberOfSlots; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uIItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    //Update slots
    public void UpdateSlot(int slot, Item item)
    {
        uIItems[slot].UpdateItem(item);
    }

    //Add item to slot
    public void AddItem(Item item)
    {
        UpdateSlot(uIItems.FindIndex(i => i.item == null), item);
    }

    //Remove item from slot
    public void RemoveItem(Item item)
    {
        UpdateSlot(uIItems.FindIndex(i => i.item == item), null);
    }
}
