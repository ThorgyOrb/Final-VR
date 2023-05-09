using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    //gamneobject of pin
    public GameObject pinGameObject;
    //bool of pin
    public bool pinBool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //on trigger enter with tag pin pin = true
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pin"))
        {
            //change position of ball
            pinBool = true;
        }
    }

    //on trigger exit with tag pin pin = false
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("pin"))
        {
            //change position of ball
            pinBool = false;
            //call coroutine
            StartCoroutine(DestroyPin());
            
        }
    }

    //courroutine to destroy pin
    IEnumerator DestroyPin()
    {
        //wait 3 seconds
        yield return new WaitForSeconds(3);
        //destroy pin
        Destroy(this.gameObject);
    }
}
