using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHUDBars : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void SetMaxStamina(float stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }

    public void SetStamina(float stamina)
    {
        slider.value = stamina;
    }

    public void SetMaxStarvationLevel(float starve)
    {
        slider.maxValue = starve;
        slider.value = starve;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetStarvationLevel(float starve)
    {
        slider.value = starve;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
