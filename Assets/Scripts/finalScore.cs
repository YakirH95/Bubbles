using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public GameObject scoreManager;
    scoreCounter ScoreCounter;

    public Text final;
    public int Score;
    // Start is called before the first frame update
    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager");
        ScoreCounter = scoreManager.GetComponent<scoreCounter>();

        Score = ScoreCounter.score;
        final.text = "Final Score " + Score.ToString() + '\n' + '\n' + "You popped : " + '\n' + ScoreCounter.bigPop.ToString() +
            " Big Bubbles" + '\n' + ScoreCounter.mediumPop.ToString() + " Medium Bubbles" + '\n' + ScoreCounter.smallPop.ToString() + " Small Bubbles";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
