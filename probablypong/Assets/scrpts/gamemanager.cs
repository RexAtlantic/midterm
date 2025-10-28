using System;
using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour

   
{
    //variables

    public GameObject cube;

    public TextMeshProUGUI text;

    public int score;
    

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Score:" + score;



    }


    
   

}
