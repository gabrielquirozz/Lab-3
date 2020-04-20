using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy2 : MonoBehaviour
{
    public Text score;
    int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        score.text = "Score :" + Score ;
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score :" + Score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Score = 1;
            score.text = "Score :" + Score;
        }
        else
        {
            Score = 0;
            score.text = "Score :" + Score;

        }
            
           

    }
}
