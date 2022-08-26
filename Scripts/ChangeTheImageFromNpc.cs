using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeTheImageFromNpc : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterReference;
    [SerializeField] private Image CharRefImage;

    [Header("Designed image")]
    [SerializeField] private Sprite[] targetImage;

    [SerializeField] private int targetIndex;

    [Header("Designed image")]
    [SerializeField] private GameObject ChatArea;


    // Start is called before the first frame update
    void Start()
    {
        ChatArea.SetActive(true);
        characterReference.sprite = targetImage[targetIndex];
        CharRefImage.sprite = targetImage[targetIndex];
        ChatArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
