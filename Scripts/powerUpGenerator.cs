using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class powerUpGenerator : MonoBehaviour
{
    public int randomNumber;
    public GameObject powerUP;
    public TextMeshProUGUI debugNum;
    public TextMeshProUGUI debugPos;
    public TextMeshProUGUI debugTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletShoot.randomNumber == 1 && Time.time >= 60)
        {
            Instantiate(powerUP, bulletShoot.killPos, Quaternion.identity);
            bulletShoot.randomNumber = 0;
        }
        //Debug.Log(bulletShoot.killPos);


        debugNum.text = "bullets: " + PlayerController.bullets;
        debugPos.text = "killPos: " + bulletShoot.killPos;
        debugTime.text = "Time: " + Time.time;
    }
}
