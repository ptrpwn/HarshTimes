using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Collectables : MonoBehaviour
{
    private Item item;

    //Pickup collectible items
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();
            
        if (controller != null)
        {
            if (gameObject.name == "Spitzhacke")
            {
                item = controller.GetComponent<Inventory>().CheckForItem(0);

                if (item.hasItem)
                {
                    Debug.Log(item.title + " already in inventory");
                }
                else
                {
                    controller.GetComponent<Inventory>().GiveItem(0);
                    item.hasItem = true;
                    Destroy(gameObject);
                }
            }
            if (gameObject.name == "Schaufel")
            {
                item = controller.GetComponent<Inventory>().CheckForItem(1);

                if (item.hasItem)
                {
                    Debug.Log(item.title + " already in inventory");
                }
                else
                {
                    controller.GetComponent<Inventory>().GiveItem(1);
                    item.hasItem = true;
                    Destroy(gameObject);
                }
            }
            if (gameObject.name == "Zange")
            {
                item = controller.GetComponent<Inventory>().CheckForItem(7);

                if (item.hasItem)
                {
                    Debug.Log(item.title + " already in inventory");
                }
                else
                {
                    controller.GetComponent<Inventory>().GiveItem(7);
                    item.hasItem = true;
                    Destroy(gameObject);
                }
            }
            if (gameObject.name == "Erdbeere")
            {
                controller.GetComponent<Inventory>().GiveItem(2);
                Destroy(gameObject);
            }
            if (gameObject.name == "Brot")
            {
                controller.GetComponent<Inventory>().GiveItem(3);
                Destroy(gameObject);
            }
            if (gameObject.name == "Kartoffel")
            {
                controller.GetComponent<Inventory>().GiveItem(4);
                Destroy(gameObject);
            }
            if (gameObject.name == "Zucker")
            {
                controller.GetComponent<Inventory>().GiveItem(5);
                Destroy(gameObject);
            }
            if (gameObject.name == "Zigaretten")
            {
                controller.GetComponent<Inventory>().GiveItem(6);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #43")
            {
                controller.GetComponent<Inventory>().GiveItem(50);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #29")
            {
                controller.GetComponent<Inventory>().GiveItem(51);
                Destroy(gameObject);
            }
        }
    }
}
