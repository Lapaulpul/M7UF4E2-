using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mono.Reflection;

public class Store : MonoBehaviour
{
    public ItemSriptableObjects Item1, Item2;
    public Image Image1, Image2;
    public TextMeshProUGUI TextItem1, TextItem2;
    public Button Buy1, Buy2;

    void OnEnable()
    {
        Image1.sprite = Item1.image;
        Image2.sprite = Item2.image;
        ChecKIfCanBuy(Item1, TextItem1, Buy1);
        ChecKIfCanBuy(Item2, TextItem2, Buy2);
    }

    public void BuyItem1()
    {
        GameManager.gameManager.ItemCollected(Item1.image, 4);
        GameManager.gameManager.CoinCollected(-Item1.price);
        ChecKIfCanBuy(Item1, TextItem1, Buy1);
        ChecKIfCanBuy(Item2, TextItem2, Buy2);
    }

    public void BuyItem2()
    {
        GameManager.gameManager.ItemCollected(Item2.image, 5);
        GameManager.gameManager.CoinCollected(-Item2.price);
        ChecKIfCanBuy(Item1, TextItem1, Buy1);
        ChecKIfCanBuy(Item2, TextItem2, Buy2);
    }

    private void ChecKIfCanBuy(ItemSriptableObjects item, TextMeshProUGUI insuCoins, Button buyButton)
    {
        if (GameManager.gameManager.Coins >- item.price)
        {
            insuCoins.text = "" + item.price;
            insuCoins.color = Color.yellow;
            buyButton.interactable = true;
        }
        else
        {
            insuCoins.text = "Insuficient Coints: " + item.price;
            insuCoins.color = Color.red;
            buyButton.interactable = false;
        }
    }
}
