using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleCreator : MonoBehaviour
{
    public GameObject player;
    public GameObject[] balls;
    int randomBall;
    float rndX;
    float rndY;
    // Start is called before the first frame update
    void Start()
    {
        RandomBall(15);
    }

    public void RandomBall(int ballsAddition)
    {
        int rndLocation = 0;
        while (rndLocation <= ballsAddition)
        {
            rndX = Random.Range(-2.5f, 2.5f);
            rndY = Random.Range(-4.5f, 2.4f);
            randomBall = Random.Range(0, 3);
            Instantiate(balls[randomBall], new Vector2(rndX, rndY), Quaternion.identity);
            rndLocation += 1;
        }
    }


}
