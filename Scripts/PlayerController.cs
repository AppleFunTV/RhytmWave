using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2;
    private float horizontal;
    private float vertical;
    public GameObject bullet;
    public static Vector2 mov;
    public static Vector2 turnPos;
    private Rigidbody2D bulletRb;
    public static byte health = 3;
    public static byte bullets = 4;
    private bool isReloading = false;
    private bool isShooting;
    private bool isAlive = false;

    //Sound
    audioManager AudioManager;

    private void Awake()
    {
        //Sound
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Sound
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mov = new Vector2(horizontal, vertical);
        rb.AddForce(mov * speed);
        

        if (Input.GetMouseButtonDown(0) && bullets != 0)
        {
            Shoot();
            isShooting = false;
        }
        if (health == 0)
        {
            GameOver();

           

        }
        if (bullets < 4 && !isReloading)
        {
            StartCoroutine(reload());
        }
        
    }
    

    void Shoot()
    {
        Instantiate(bullet, GameObject.Find("Player").transform.position, Quaternion.identity);
        bullets--;
        isShooting = true;

        //Sound
        AudioManager.PlaySFX(AudioManager.shoot);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("enemyBullet"))
        {
            StartCoroutine(healthMinus());

            //Sound
            AudioManager.PlaySFX(AudioManager.hitPlayer);
        }
    }
    /*private void OnTriggerExit2D(Collider2D other)
    {
        StopCoroutine(healthMinus());
    }*/

    void GameOver()
    {
        Time.timeScale = 0;
        if  (isAlive)
            {
            isAlive = false;
        //Sound
        AudioManager.PlaySFX(AudioManager.death);
    }
        

    }
    IEnumerator reload()
    {
        
       
            isReloading = true;
            yield return new WaitForSeconds(1.5f);
            bullets = 4;
            isReloading = false;
        
       
    }
    IEnumerator healthMinus()
    {
        yield return new WaitForSeconds(0);
        health--;
    }
}
