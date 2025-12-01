using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavingMenu : MonoBehaviour
{
    private Vector2 waving;
    private float speed =  0.2f;
    private bool isCycle = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(waving * speed * Time.deltaTime);
        Debug.Log(waving);
        if (isCycle == true)
        {
            StartCoroutine(vectorChange());
            isCycle = false;
        }
    }
    
    IEnumerator vectorChange()
    {
        waving = Vector2.right;
        yield return new WaitForSeconds(5);
        waving = Vector2.left;
        yield return new WaitForSeconds(5);
        isCycle = true;
    }
}
