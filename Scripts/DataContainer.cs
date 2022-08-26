using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Economy from the player")]
    [SerializeField] public int money = 120;

    [Header("Items from player")]
    [SerializeField] public int[] inventoryNumeration = new int[12];

    [Header("sprites from Items")]
    [SerializeField] public Sprite[] inventorySprites = new Sprite[30];

    
}
