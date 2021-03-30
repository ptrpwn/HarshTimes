using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Item item;
    public UIHUDBars healthBar;

    private Image spriteImage;
    private UIItem selectedItem;
    private UITooltip tooltip;
    private PlayerController player;

    private void Awake()
    {
        spriteImage = GetComponent<Image>();
        UpdateItem(null);
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        tooltip = GameObject.Find("Tooltip").GetComponent<UITooltip>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void Start()
    {
        tooltip.gameObject.SetActive(false);
    }

    //Update inventory slots
    public void UpdateItem(Item item)
    {
        this.item = item;
        if (item != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;
        }
        else
        {
            spriteImage.color = Color.clear;
        }
    }

    //Move and use item
    public void OnPointerClick(PointerEventData eventData)
    {
        //Move item in inventory (lmb)
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (item != null)
            {
                if (selectedItem.item != null)
                {
                    Item clone = new Item(selectedItem.item);
                    selectedItem.UpdateItem(item);
                    UpdateItem(clone);
                }
                else
                {
                    selectedItem.UpdateItem(item);
                    UpdateItem(null);
                }
            }
            else if (selectedItem.item != null)
            {
                UpdateItem(selectedItem.item);
                selectedItem.UpdateItem(null);
            }
        }

        //Use item (rmb)
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (item != null)
            {
                if (selectedItem.item != null)
                {
                    Item clone = new Item(selectedItem.item);
                    selectedItem.UpdateItem(item);
                    UpdateItem(clone);
                    Debug.Log("cloned item");
                }
                else
                {
                    if (item.id == 0 || item.id == 1 || item.id == 7)
                    {
                        if (item.stats["Haltbarkeit"] > 1)
                        {
                            int i = item.stats["Haltbarkeit"];
                            item.stats["Haltbarkeit"] = i - 1;
                            i = item.stats["Haltbarkeit"];
                            UpdateItem(item);
                            tooltip.GenerateTooltip(item);

                            player.ChangeStamina(-1);
                            player.ChangeStarvationLevel(-0.1f);
                        }
                        else
                        {
                            item.hasBreakoutItem = false;
                            item.stats["Haltbarkeit"] = 10;
                            tooltip.gameObject.SetActive(false);
                            UpdateItem(null);
                        }
                    }
                    else if (item.id == 2)
                    {
                        player.ChangeStamina(1);
                        player.ChangeStarvationLevel(0.5f);
                        tooltip.gameObject.SetActive(false);
                        UpdateItem(null);
                    }
                    else if (item.id == 3)
                    {
                        if (item.stats["Menge"] >= 1)
                        {
                            int i = item.stats["Menge"];
                            item.stats["Menge"] = i - 1;
                            i = item.stats["Menge"];
                            UpdateItem(item);
                            tooltip.GenerateTooltip(item);

                            player.ChangeHealth(1);
                            player.ChangeStarvationLevel(1f);
                        }
                        if (item.stats["Menge"] == 0)
                        {
                            tooltip.gameObject.SetActive(false);
                            UpdateItem(null);
                        }
                    }
                    else if (item.id == 4)
                    {
                        player.ChangeStarvationLevel(0.5f);
                        tooltip.gameObject.SetActive(false);
                        UpdateItem(null);
                    }
                    else if (item.id == 5)
                    {
                        player.ChangeStamina(5);
                        tooltip.gameObject.SetActive(false);
                        UpdateItem(null);
                    }
                }
            }
            else if (selectedItem.item != null)
            {
                UpdateItem(selectedItem.item);
                selectedItem.UpdateItem(null);
            }
        }
    }

    //Show tooltip
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            tooltip.GenerateTooltip(item);
            tooltip.gameObject.SetActive(!tooltip.gameObject.activeSelf);
        }
    }
    
    //Hide tooltip
    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.gameObject.SetActive(false);
    }
}
