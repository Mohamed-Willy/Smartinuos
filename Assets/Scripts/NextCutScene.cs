using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextCutScene : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private string SceneName;
    void Start()
    {
        Invoke("next", time);
    }

    void next()
    {
        if(SceneManager.GetActiveScene().name == "WinningScene")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        SceneManager.LoadScene(SceneName);
    }
}
