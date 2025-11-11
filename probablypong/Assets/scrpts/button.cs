using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class button : MonoBehaviour
{

    //variables

    public InputActionReference gamestart;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gamestart.action.WasPressedThisFrame())
        {
            SceneManager.LoadScene("SampleScene");
        }
        
 
    }



    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
