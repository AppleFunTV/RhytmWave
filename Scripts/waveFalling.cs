using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waveFalling : MonoBehaviour
{
    public TextMeshProUGUI wave;
    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waveFall());
        pos = new Vector2(57.779f, 104);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waveFall()
    {
        yield return new WaitForSeconds(5);

        wave.transform.Translate(pos * 3 * Time.deltaTime);
    }
}
