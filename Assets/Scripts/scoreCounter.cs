using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreCounter : MonoBehaviour
{
    public Text scoretxt;
    public Text clickstxt;
    
    public int smallPop;
    public int mediumPop;
    public int bigPop;
    public int score;
    public int clicks;

    // Start is called before the first frame update
    void Start()
    {
        smallPop = 0;
        mediumPop = 0;
        bigPop = 0;
        
        scoretxt.text = "Score " +score.ToString();
        clickstxt.text = "Pops " + clicks.ToString();

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (clicks == 0)
        {
            SceneManager.LoadScene("Score");
        }
    }

    public void IncreaseScore(int clicksAddition, bool isBig, bool isMedium, bool isSmall)
    {
        score += 10;
        clicks += clicksAddition;

        if (isBig)
        {
            bigPop++;
        }

        else if (isMedium)
        {
            mediumPop++;
        }

        else if (isSmall)
        {
            smallPop++;
        }

        scoretxt.text ="Score "+ score.ToString();
        clickstxt.text ="Clicks "+ clicks.ToString();
    }
}
