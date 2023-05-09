using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagger : MonoBehaviour
{
    //int for pins
    public int pins;
    public int round;
    public int balls;
    //text mesh pro for round
    public TextMeshProUGUI roundText;
   


    void Start()
    {
        round = 1;
        
    }

    void Update()
    {
        //set round text to round
        roundText.text = round.ToString();
        //count all objects with tag pin
        pins = GameObject.FindGameObjectsWithTag("pinO").Length;
        //count all objects with ballB
        balls = GameObject.FindGameObjectsWithTag("ballB").Length;

        if(balls ==0){
            round++;
            //destroy pins remaining
            GameObject[] pins = GameObject.FindGameObjectsWithTag("pinO");
            for (int i = 0; i < pins.Length; i++)
            {
                Destroy(pins[i]);
                if(pins.Length == 0)
                {
                    break;
                }
            }

        

        }

        //if pins round ++
        if (pins == 0 && (balls == 1 || balls == 0))
       
       
        {
            //destroy all balls
            GameObject[] balls = GameObject.FindGameObjectsWithTag("ballB");
            for (int i = 0; i < balls.Length; i++)
            {
                Destroy(balls[i]);
                if(balls.Length == 0)
                {
                    break;
                }
            }
          
         
        }
        
    }

  


}
