using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMen;
    [Header("Where to click 4 the button appear:")]
    [SerializeField] private string letterButton;


    [Header("The array that countains each item on inventory")]
    [SerializeField] public Image[] inventoryCollection = new Image[12];

    [Header("Select the money from inventory")]
    [SerializeField] private Text moneyAmountInvent;

    [Header("SelectThe Data Container")]
    [SerializeField] private GameObject moneyValue;


    [Header("Set the reference for items assets on character")]
    [SerializeField] private SpriteRenderer head;
    [SerializeField] private SpriteRenderer tail;
    [SerializeField] private SpriteRenderer body;

    


    //Number of the atual item on invent
    private int inventNumber;



    void Update()
    {
        LookWhenClicked();
    }

    private void LookWhenClicked()
    {
        if (Input.GetKeyDown(letterButton))
        {
            AppearPause();
        }
    }



    public void AppearPause()
    {
        pauseMen.SetActive(!pauseMen.activeSelf);
    }

    //Corrigir repetição posteriormente para manter as boas praticas ||moneyValue.GetComponent<DataContainer>()||
    //==========This will fix the inventory even the name being called as the store========
    public void FixTheStore()
    {
        moneyAmountInvent.text = moneyValue.GetComponent<DataContainer>().money.ToString();
        foreach(Image item in inventoryCollection)
        {
            //Debug.Log(item);
            inventNumber = System.Array.IndexOf(inventoryCollection, item);
            //Debug.Log(inventNumber);
            if(moneyValue.GetComponent<DataContainer>().inventoryNumeration[inventNumber] == 0)
            {
                Debug.Log("Ta vazio. Acabou a chegagem");
                break;
            }
            else
            {
                verifyItem(moneyValue.GetComponent<DataContainer>().inventoryNumeration[inventNumber]);
                Debug.Log(moneyValue.GetComponent<DataContainer>().inventoryNumeration[inventNumber]);
                //itemIndex
            }


        }

    }

    public void verifyItem(int itemIndex)
    {
        inventoryCollection[inventNumber].sprite = moneyValue.GetComponent<DataContainer>().inventorySprites[itemIndex];
    }


    public void equipItem(Image im)
    {
        Debug.Log("Nome do item: " + im.sprite.name);
        int itemLoc;
        int.TryParse(im.sprite.name, out itemLoc);


        if(itemLoc <= 10)
        {
            head.GetComponent<SpriteRenderer>().sprite = im.sprite;
        }
        else if(itemLoc <= 20)
        {
            tail.GetComponent<SpriteRenderer>().sprite = im.sprite;
        }
        else if (itemLoc <= 30)
        {
            body.GetComponent<SpriteRenderer>().sprite = im.sprite;
        }
    }
}