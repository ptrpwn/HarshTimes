using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITooltip : MonoBehaviour
{
    private Text tooltip;
    public void Awake()
    {
        tooltip = GetComponentInChildren<Text>();
    }
    
    //Generate tooltip for item
    public void GenerateTooltip(Item item)
    {
        string statText = "";
        if (item.stats.Count > 0)
        {
            foreach(var stat in item.stats)
            {
                statText += $"{stat.Key}: {stat.Value}\n";
                //statText += stat.Key.ToString() + ": " + stat.Value.ToString() + "\n";
            }
        }
        
        string tooltipText = $"<b>{item.title}</b>\n{item.description}\n\n<b>{statText}</b>";
        tooltip.text = tooltipText;
        tooltip.gameObject.SetActive(true);
    }
}
