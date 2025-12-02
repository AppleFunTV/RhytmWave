using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justShooting : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootForTime", 2, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void shootForTime()
    {
        Instantiate(enemyBullet, enemy.transform.position, Quaternion.identity);
    }
}
