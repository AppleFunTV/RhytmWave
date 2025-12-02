using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class following : MonoBehaviour
{
    private Rigidbody2D enemyrb;
    public float speed = 25f;
    private GameObject player;
    private Vector2 distance;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distance = (player.transform.position - transform.position).normalized;
        //FollowingPlayer();
        StartCoroutine(followingDelay());
    }
    void FollowingPlayer()
    {
        enemyrb.AddForce(distance * speed);
    }
    IEnumerator followingDelay()
    {
        yield return new WaitForSeconds(0.4f);
        FollowingPlayer();
    }
}