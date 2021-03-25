using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject BubbleCreator;
    bubbleCreator bubbleCreator;

    public GameObject soundManager;
    soundManager soundScript;

    // Start is called before the first frame update
    void Start()
    {
        bubbleCreator = BubbleCreator.GetComponent<bubbleCreator>();
        soundScript = soundManager.GetComponent<soundManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            bubbleCreator.RandomBall(10);
            soundScript.playNewBubbles();
            transform.position = new Vector2(transform.position.x, transform.position.y + 7);
        }
    }

}
