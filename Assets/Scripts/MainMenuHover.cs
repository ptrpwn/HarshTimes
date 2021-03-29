using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHover : MonoBehaviour
{
    // Update is called once per frame
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
