using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityFromStores : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerImage;
    [SerializeField] private SpriteRenderer image;
    void Start()
    {
        image = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            image.color = new Color(1f,1f,1f,0.5f);
            playerImage = other.GetComponent<SpriteRenderer>();
            playerImage.sortingOrder = 1;
        }
    }





    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            image.color = new Color(1f,1f,1f,1f);
            playerImage.sortingOrder = 6;
        }
    }
    


}
