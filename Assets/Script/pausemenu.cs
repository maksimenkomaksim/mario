using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause)
            {
                Resum();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {   
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
    public void Resum()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1sf;
        pause = false;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }
}
