using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //destroy ball if it goes out of bounds
        if (this.gameObject.transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
        
    }
    //on trigger enter with tag ball destroy ball
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            //change position of ball
            this.gameObject.transform.position = new Vector3(6.117f, 0.572f, -1.721803f);
            
        }
    }

}
