using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.active)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

}
