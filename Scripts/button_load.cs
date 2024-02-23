using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_load : MonoBehaviour
{
    public int scene;

    public void buttonPlay()
    {
        SceneManager.LoadScene(scene);
    }
}
