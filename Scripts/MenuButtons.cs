using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public static bool isRestart;

    //Sound
    AudioManagerMenu AudioManager;

    private void Awake()
    {
        //Sound
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerMenu>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonPressed()
    {
       
        SceneManager.LoadScene(1);
        GameObject.Find("gameOverPanel").SetActive(false);
        



    }
    public void ExitButtonPressed()
    {
        

        Application.Quit();
      
    }
    public void MenuButtonPressed()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        PlayerController.health = 3;

    }
    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isRestart = true;
    }
}
