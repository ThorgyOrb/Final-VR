using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    //rigybody 3d   
    public Rigidbody ballRigidbody;
    //variable of game manager
    public GameManagger gameManagger;
  

    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
        SpawnBall();
        

        
    }

    // Update is called once per frame
    void Update()
    {
      //if balls in game manager is 0
        if(gameManagger.balls == 0)
            {
                //spawn ball
                SpawnBall();
                SpawnBall();
            }

        
    
        
    }

    //spawn ball
    public void SpawnBall()
    {
        //instantiate ball
        GameObject ball = Instantiate(ballPrefab);
        //set ball position
        ball.transform.position = transform.position;
        //get ball rigidbody
        ballRigidbody = ball.GetComponent<Rigidbody>();
        //add force to ball
        ballRigidbody.AddForce(0, -500, 0);
        //call OnCollisionEnter
        
        
  

      


        
    }
  

}
