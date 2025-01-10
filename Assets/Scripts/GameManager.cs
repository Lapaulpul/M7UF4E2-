using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI CoinText, OrbText;
    public Image[] Items;
    public static GameManager gameManager;
    public int Orbs = 0, Coins = 0;

    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
            Destroy(gameObject);

        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void OrbCollected()
    {
        Orbs++;
        OrbText.text = Orbs.ToString();
        Debug.Log("orbe");
    }

    public void CoinCollected(int i)
    {
        Coins+= i;
        CoinText.text = Coins.ToString();
        Debug.Log("coin");
    }

    public void ItemCollected(Sprite sprite,int id)
    {
        Items[id].sprite = sprite;
    }
}
