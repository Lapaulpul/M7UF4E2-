using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour, ICollectables
{
    public int ID;
    public Sprite Sprite;
    public void Collect()
    {
        GameManager.gameManager.ItemCollected(Sprite, ID);
        Destroy(gameObject);

    }
}