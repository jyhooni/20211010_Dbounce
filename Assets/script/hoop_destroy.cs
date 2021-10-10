using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoop_destroy : MonoBehaviour
{
    public GameObject hoop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D co)
    {

        Debug.Log("2222");

        if (co.transform.tag == "ball")
        {
            Debug.Log("ttttttttttttttt");
            Destroy(hoop.gameObject);


        }
    }

}
