using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    public string sceneToLoad;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) == true)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
