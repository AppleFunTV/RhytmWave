using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollow : MonoBehaviour
{
    private Rigidbody2D bulletRB;
    public float speed = 0.6f;
    private GameObject player;
    private Vector2 distance;

    //Sound
    audioManager AudioManager;

    private void Awake()
    {
        //Sound
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }

    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        StartCoroutine(Destroying());
        AudioManager.PlaySFX(AudioManager.shootEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        distance = (player.transform.position - transform.position).normalized;
        //FollowingPlayer();
        FollowingPlayer();
    }
    void FollowingPlayer()
    {
        bulletRB.AddForce(distance * speed);
    }
    IEnumerator Destroying()
    {
        yield return new WaitForSeconds(7);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameController"))
        {
            Destroy(gameObject);
        }
    }
}