using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    public bool hasBreakoutItem;

    //Create item in inventory
    public Item(int id, string title, string description, Dictionary<string,int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.stats = stats;
        hasBreakoutItem = true;

        if (this.id == 50 || this.id == 51 || this.id == 52 || this.id == 53 || this.id == 54 || this.id == 55 || this.id == 56)
        {
            icon = Resources.Load<Sprite>("Sprites/Items/Tagebucheintrag");
        }
        else
        {
            icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        }
    }

    //Copy and create another item
    public Item(Item item)
    {
        id = item.id;
        title = item.title;
        description = item.description;
        icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        stats = item.stats;
        hasBreakoutItem = item.hasBreakoutItem;
    }
}
