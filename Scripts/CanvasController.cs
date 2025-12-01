using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    private bool IsActive;
    public GameObject DebugText;
    private bool IsActive1;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (!IsActive)
            {
                IsActive = true;
                DebugText.SetActive(true);
            }
            else
            {
                DebugText.SetActive(false);
                IsActive = false;
            }
        }
        if (PlayerController.health == 0)
        {
            IsActive1 = true;
            gameOverPanel.SetActive(true);
        }
        if (MenuButtons.isRestart == true)
        {
            gameOverPanel.SetActive(false);
            Time.timeScale = 1;
            PlayerController.health = 3;
            spawnManager.waveCounter = 0;
            bulletShoot.intScore = 0;
            MenuButtons.isRestart = false;
            
        }



    }

}


