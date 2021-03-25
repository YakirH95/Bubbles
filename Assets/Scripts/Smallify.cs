using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smallify : MonoBehaviour
{
    public int life;
    public bool isSmall;
    public bool isMedium;
    public bool isLarge;

    //score
    public GameObject scorer;
    scoreCounter scoreScript;

    //sound
    GameObject soundManager;
    soundManager soundScript;

    //effects
    public GameObject splash;
    public GameObject bigSplash;

     void Start()
    {
        //score management
        scorer = GameObject.Find("ScoreManager");
        scoreScript = scorer.GetComponent<scoreCounter>();

        //sound management
        soundManager = GameObject.Find("Sound Manager");
        soundScript = soundManager.GetComponent<soundManager>();
    }

    private void Update()
    {
        if (life == 0)
        {
            Destroy(gameObject);
            soundScript.playPop();
            Instantiate(bigSplash, transform.position, Quaternion.identity);

            if (isSmall)
            {
                scoreScript.IncreaseScore(2, false, false, true);
            }

            else if (isMedium)
            {
                scoreScript.IncreaseScore(3, false, true, false);
            }

            else if (isLarge)
            {
                scoreScript.IncreaseScore(4, true, false, false);
            }
        }
    }

    public void OnMouseDown()
    {
        life--;

        if (life > 0)
        {
            soundScript.playSmallPop();
            Instantiate(splash, transform.position, Quaternion.identity);
        }

        transform.localScale = new Vector2(transform.localScale.x - 0.2f, transform.localScale.y - 0.2f);
        scoreScript.clicks--;
        scoreScript.clickstxt.text = "Clicks " + scoreScript.clicks.ToString();
    }
}
