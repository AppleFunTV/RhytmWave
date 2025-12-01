using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private GameObject currentEnemy;
    private GameObject currentEnemy1;
    private GameObject currentEnemy2;
    private GameObject currentEnemy3;
    private float spawnInterval = 7;
    public static int waveCounter;
    public TextMeshProUGUI wave;
    private bool isStarted = true;
    private bool isStopped;
    private Vector2 wavePos;
    public GameObject wavePrefab;

    //Sound
    audioManager AudioManager;


    private void Awake()
    {
        //Sound
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }
   
    void Start()
    {
        /*InvokeRepeating("spawnEnemies", 3, spawnInterval);
        InvokeRepeating("spawnEnemies1", 3, spawnInterval);
        InvokeRepeating("spawnEnemies2", 3, spawnInterval);*/
        StartCoroutine(spawn());
        
    }

    // Update is called once per frame
    void Update()
    {
        currentEnemy = enemies[Random.Range(0, enemies.Length)];
        currentEnemy1 = enemies[Random.Range(0, enemies.Length)];
        currentEnemy2 = enemies[Random.Range(0, enemies.Length)];
        currentEnemy3 = enemies[Random.Range(0, enemies.Length)];

        if (Time.time > 30f)
        {
            spawnInterval = 3;
        }
        if (Time.time > 60)
        {
            spawnInterval = 2;
        }
        wave.text = "Wave: " + waveCounter;
        
        
    }

    void spawnEnemies()
    {
        Vector2 spawnArea = new Vector2(Random.Range(-12, 12), 7.42f);
        Instantiate(currentEnemy, spawnArea, Quaternion.identity);
        waveCounter++;

        //Sound
        AudioManager.PlaySFX(AudioManager.wave);

    }
    void spawnEnemies1()
    {
        Vector2 spawnArea = new Vector2(Random.Range(-12, 12), 7.42f);
        Instantiate(currentEnemy1, spawnArea, Quaternion.identity);

    }
    void spawnEnemies2()
    {
        Vector2 spawnArea = new Vector2(Random.Range(-12, 12), 7.42f);
        Instantiate(currentEnemy2, spawnArea, Quaternion.identity);

    }
    void spawnEnemies3()
    {
        Vector2 spawnArea = new Vector2(Random.Range(-12, 12), 7.42f);
        Instantiate(currentEnemy3, spawnArea, Quaternion.identity);

    }
    IEnumerator spawn()
    {
        while (true)
        {
            Vector2 wavePos = new Vector2(-0.01f, 7.29f);
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(wavePrefab, wavePos, Quaternion.identity);
            spawnEnemies();
            yield return new WaitForSeconds(1.5f);
            Destroy(GameObject.Find("Wave(Clone)"));
            if (Time.time > 20)
            {
                spawnEnemies1();
            }
            if (Time.time > 40)
            {
                spawnEnemies2();
            }
            if (Time.time > 120)
            {
                spawnEnemies3();
            }
        }
        
    }

}
