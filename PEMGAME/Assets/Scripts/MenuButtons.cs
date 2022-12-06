using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void LoadScene(string sceneToload)
    {
        SceneManager.LoadScene(sceneToload);
    }

    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadUrl()
    {
        Application.OpenURL("https://www.instagram.com/pti20aja/");
    }
}
