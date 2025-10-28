using Unity.VisualScripting;
using UnityEngine;

public class destroy : MonoBehaviour
{

    public GameObject cube;

    public gamemanager gm;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        gm.SpawnPong();
    }


}
