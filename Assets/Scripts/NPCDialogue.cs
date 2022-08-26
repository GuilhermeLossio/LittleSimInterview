using UnityEngine;
using UnityEngine.UI;


public class NPCDialogue : MonoBehaviour
{
    [SerializeField] private GameObject DialogueArea;
    [SerializeField] private Animation anim;
    


    //=======Here i goint to define the talk variable==================
    //=======DEFINIMOS AS FALAS=====================
    public Text speechText;

    [SerializeField] private Text npcNameText;


    [Header("Components")]
    public GameObject dialogueObj;

    [Header("Is a seller?")]
    [SerializeField] private bool seller;
    [SerializeField] private GameObject sellerIcon;
    [SerializeField] private GameObject sellerItems;

    [Header("Select the money from store")]
    [SerializeField] private Text moneyAmount;

    //==========Here we going to define the player gameObject that contains the money amount===========
    [SerializeField] private GameObject playerData;




    //===================================

    [Header("NPC Name")]
    [SerializeField] private string npcName = "A name";


    [Header("Dialogues")]
    public string[] sentences;
    private int index;

    [Header("Items on store")]
    public Image[] imagesItemStore = new Image[4];
    public int[] valuesFromStoreIndex = new int[4];




    void Start()
    {
        index = 1;
        speechText.text = sentences[0];
        npcNameText.text = npcName;
        if(seller == true)
        {
            sellerIcon.SetActive(true);
        }
    }

    //This is the code that will be used on dialogues
    public void Falar()
    {
        if (index < sentences.Length)
        {
        speechText.text = sentences[index];
        index += 1;
        }
        else
        {
        speechText.text = sentences[0];
        index = 1;
        dialogueObj.SetActive(false);
        }
    }

    void Update()
    {
        verifyNextDialogue();
    }

    //Verify when the dialogue is pressed
    private void verifyNextDialogue()
    {
        if(dialogueObj.activeSelf && Input.GetButtonDown("Fire1"))
        {
            Falar();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("NPCVerifyer"))
        {
            DialogueArea.SetActive(true);
            anim.Play("NPCAppear");
            if(seller == true)
            {
                //=======Here we get the code that contains the data=============
                playerData = other.gameObject;

                //=======Here we get the code that contains the data=============
                sellerItems.SetActive(true);
                moneyAmount.text = playerData.GetComponent<DataContainer>().money.ToString();
                
                //PlaceTheItemsOnStore
                foreach(Image imStor in imagesItemStore)
                {
                    //Get the atual index
                    int itemIndex = System.Array.IndexOf(imagesItemStore, imStor);
                    //Get atual item value
                    int tempLoc = valuesFromStoreIndex[itemIndex];
                    //Change the image using the atual item code
                    imStor.sprite = playerData.GetComponent<DataContainer>().inventorySprites[tempLoc];
                    //Debug.Log(imStor);
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D colliotherder)
    {
        DialogueArea.SetActive(false);
    }






    public void BuyAItem(int itemIndexVal)
    {
        //A list from the items on inventory
        int[] inventoryNumbers = playerData.GetComponent<DataContainer>().inventoryNumeration;

        //Here we get the money amount
        int money = playerData.GetComponent<DataContainer>().money;

        foreach(int item in inventoryNumbers)
        {

            Debug.Log(item);
            int inventNumber = System.Array.IndexOf(inventoryNumbers, item);
            //Debug.Log(inventNumber);
            if(playerData.GetComponent<DataContainer>().inventoryNumeration[inventNumber] == 0 && (money - 20) >= 0)
            {
                Debug.Log("Ta vazio. Vamos inserir aqui");
                playerData.GetComponent<DataContainer>().inventoryNumeration[inventNumber] = valuesFromStoreIndex[itemIndexVal - 1];
                playerData.GetComponent<DataContainer>().money = money - 20;
                money -= 20;
                moneyAmount.text = money.ToString();
                break;
            }
            else
            {
                Debug.Log("Já tem item");
                //playerData.GetComponent<DataContainer>().inventoryNumeration[inventNumber] = itemIndexVal;
                //itemIndex
            }
        }
    }
}
