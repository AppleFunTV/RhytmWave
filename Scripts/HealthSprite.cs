using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSprite : MonoBehaviour
{
    private SpriteRenderer HP;
    public Sprite twoHP;
    public Sprite halfHP;
    public Sprite noHP;
    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.health == 2)
        {
            HP.sprite = twoHP;
        }
        else if (PlayerController.health == 1)
        {
            HP.sprite = halfHP;
        }
        else if (PlayerController.health == 0)
        {
            HP.sprite = noHP;
        }
    }
}
