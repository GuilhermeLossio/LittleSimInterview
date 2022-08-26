using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeAmountAndScore : MonoBehaviour
{
    public int life = 100;

    public int timeInGame = 0;
    public GameObject result;
    public Image medalPlace;
    public Text ScoreCount;


    public Sprite[] medals = new Sprite[3];

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncressTime", 1.0f, 1.0f);
    }



    public void IncressTime()
    {
        timeInGame++;
    }

    // Update is called once per frame
    public void DecressLife()
    {
        life -= 10;
        if (life <= 0)
        {
            Time.timeScale = 0;
            result.SetActive(true);
            if(timeInGame < 20)
            {
                medalPlace.sprite = medals[0];
            }
            else if (timeInGame < 40)
            {
                medalPlace.sprite = medals[1];
            }
            else if (timeInGame < 80)
            {
                medalPlace.sprite = medals[2];
            }
            ScoreCount.text = timeInGame.ToString();

        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
