using System;
using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour

   
{
    //variables

    public GameObject cube;

    public TextMeshProUGUI text;

    public int score;

    public static gamemanager instance;




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gamemanager.instance);
        }

        else
        {
            Destroy(gamemanager.instance);
        }
    }




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Score:" + score;

        

    }



    public void SpawnPong()
    {
        Instantiate(cube, new Vector2(0f, 0f), cube.transform.rotation);
    }


    
   

}
