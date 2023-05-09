using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class images : MonoBehaviour
{
    public Image icon;
    public GameObject[] butt = new GameObject[7]; 
    // Start is called before the first frame update
    void Start()
    {
        icon.enabled = false;
         //set false butt 3
        butt[3].SetActive(false);
        //set false butt 4
        butt[4].SetActive(false);
        //set false butt 5
        butt[5].SetActive(false);
        //set false butt 6
        butt[6].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    //change image
    public void ChangeImage(int i)
    {
        icon.enabled = true;
        //set false butt 0
        butt[0].SetActive(false);
        //set false butt 1
        butt[1].SetActive(false);
        //set false butt 2
        butt[2].SetActive(false);
        //set true butt 3
        butt[3].SetActive(true);
        //set true butt 4
        butt[4].SetActive(true);
        //set false butt 5
        butt[5].SetActive(false);
        //set false butt 6
        butt[6].SetActive(false);

        icon.sprite = Resources.Load<Sprite>("Icon/Bowl");

    }
    public void PlayBasquet(){
        icon.enabled = true;
        //set false butt 0
        butt[0].SetActive(false);
        //set false butt 1
        butt[1].SetActive(false);
        //set false butt 2
        butt[2].SetActive(false);
        //set false butt 3
        butt[3].SetActive(false);
        //set false butt 4
        butt[4].SetActive(true);
        //set true butt 5
        butt[5].SetActive(true);
        //set true butt 6
        butt[6].SetActive(false);

        icon.sprite = Resources.Load<Sprite>("Icon/Basquet");

    }

    public void PlayDarts(){
        icon.enabled = true;
        //set false butt 0
        butt[0].SetActive(false);
        //set false butt 1
        butt[1].SetActive(false);
        //set false butt 2
        butt[2].SetActive(false);
        //set false butt 3
        butt[3].SetActive(false);
        //set false butt 4
        butt[4].SetActive(true);
        //set false butt 5
        butt[5].SetActive(false);
        //set true butt 6
        butt[6].SetActive(true);

        icon.sprite = Resources.Load<Sprite>("Icon/Darts");

    }

    public void Back()
    {
        icon.enabled = false;
        //set true butt 0
        butt[0].SetActive(true);
        //set true butt 1
        butt[1].SetActive(true);
        //set true butt 2
        butt[2].SetActive(true);
        //set false butt 3
        butt[3].SetActive(false);
        //set false butt 4
        butt[4].SetActive(false);
        //set false butt 5
        butt[5].SetActive(false);
        //set false butt 6
        butt[6].SetActive(false);
    }

    //open the scene of the game  called "Game" 
    public void OpenGameBoliche()
    {
        SceneManager.LoadScene("Boliche");
    }


}
