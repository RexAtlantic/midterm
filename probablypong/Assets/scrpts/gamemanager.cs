using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Debug.Log("gone");
            Destroy(gameObject);
        }

        
        SpawnPong();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Score:" + score;

        if (score <= -1)
        {
            SceneManager.LoadScene("END");

            score = 0;

        }

    }



    public void SpawnPong()
    {
        Instantiate(cube, new Vector2(0f, 0f), cube.transform.rotation);
    }

    



}
