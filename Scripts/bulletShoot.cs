using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{
    public static float intScore;
    public static int randomNumber;
    public GameObject powerUP;
    public static Vector2 killPos;

    //Sound
    audioManager AudioManager;


    private void Awake()
    {
        //Sound
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 10 * Time.deltaTime);
        if (transform.position.y > 10.5f)
        {
            Destroy(gameObject);
        }

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            intScore++;
            randomNumber = Random.Range(0, 20);
            killPos = transform.position;

            //Sound
            AudioManager.PlaySFX(AudioManager.hit[Random.Range(0, AudioManager.hit.Length)]);
            AudioManager.PlayNotes(AudioManager.musicNotes[Random.Range(0, AudioManager.musicNotes.Length)]);

        }
        
    }
}
