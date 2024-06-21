using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFruit : MonoBehaviour
{
    public Sprite[] FruitSprites;
    static public int nextFruitID;
    void Start()
    {
        Change();
    }

    public void Change(){
        nextFruitID = Random.Range(0, FruitSprites.Length);
        GetComponent<SpriteRenderer>().sprite = FruitSprites[nextFruitID];
    }
}
