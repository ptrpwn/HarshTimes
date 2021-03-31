using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Collectables : MonoBehaviour
{
    //Pickup collectable items
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();
            
        if (controller != null)
        {
            if (gameObject.name == "Spitzhacke")
            {
                controller.GetComponent<Inventory>().GiveItem(0);
                Destroy(gameObject);
            }
            if (gameObject.name == "Schaufel")
            {
                controller.GetComponent<Inventory>().GiveItem(1);
                Destroy(gameObject);
            }
            if (gameObject.name == "Zange")
            {
                controller.GetComponent<Inventory>().GiveItem(7);
                Destroy(gameObject);
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
            if (gameObject.name == "Tagebucheintrag #1")
            {
                controller.GetComponent<Inventory>().GiveItem(52);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #17")
            {
                controller.GetComponent<Inventory>().GiveItem(53);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #25")
            {
                controller.GetComponent<Inventory>().GiveItem(54);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #38")
            {
                controller.GetComponent<Inventory>().GiveItem(55);
                Destroy(gameObject);
            }
            if (gameObject.name == "Tagebucheintrag #39")
            {
                controller.GetComponent<Inventory>().GiveItem(56);
                Destroy(gameObject);
            }
        }
    }
}
