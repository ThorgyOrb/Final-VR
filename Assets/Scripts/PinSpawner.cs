using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    
    public GameObject pinPrefab;
    public GameManagger gameManagger;


    // Start is called before the first frame update
    void Start()
    {
        SpawnPin();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //if pins in game manager = 0 spawn pins
        if (gameManagger.pins == 0)
        {
            SpawnPin();
        }
        
    }

    void SpawnPin()
    {
        //spawn a pin in position x=0, y=-2.5, z=0
        Instantiate(pinPrefab, new Vector3(-2.890707f, 0, -3.103f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.166724f, 0, -3.251021f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.152777f, 0, -2.985219f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.41461f, 0, -3.355676f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.417835f, 0, -3.113913f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.400674f, 0, -2.865587f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.661452f, 0, -3.499624f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.659456f, 0, -3.24162f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.647049f, 0, -2.996161f), transform.rotation);
        Instantiate(pinPrefab, new Vector3(-3.635063f, 0, -2.758185f), transform.rotation);
        


    }
}

