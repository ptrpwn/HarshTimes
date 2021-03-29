using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool start;
    public bool credits;
    public bool back;
    public bool quit;

    private void OnMouseUp()
    {
        if (start)
        {
            SceneManager.LoadScene(1);
        }
        if (credits)
        {
            SceneManager.LoadScene(2);
        }
        if (back)
        {
            SceneManager.LoadScene(0);
        }
        if (quit)
        {
            Application.Quit();
        }
    }
}
