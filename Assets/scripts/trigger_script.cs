using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class trigger_script : MonoBehaviour
{

    public string choosenTag;

    public AudioSource rightSound;
    public AudioSource flaseSound;


    public Text MyScoreText;
    public int scoreNum;

    // Tags available: trash_blue, trash_orange and trash_green



    public void Start()
    {
        scoreNum = 0;
        MyScoreText.text = "Score = " + scoreNum;
    }


    

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == choosenTag)
        {
            Debug.Log("RIGHT");
            rightSound.Play();
            scoreNum += 1;
            MyScoreText.text = "Score = " + scoreNum;

        }
        else
        {
            Debug.Log("FALSE");
            flaseSound.Play();
            scoreNum -= 1;
            MyScoreText.text = "Score = " + scoreNum;
        }
       

    }
}
