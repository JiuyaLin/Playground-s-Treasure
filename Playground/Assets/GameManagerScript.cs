using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private GameObject  worm;
    private GameObject  star;
    
    // Start is called before the first frame update
    void Start()
    {
        star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Slide")
        {
            Destroy(collision.gameObject);
            print("hit");

        }


        if (collision.gameObject.name == "swing")
        {
            Destroy(collision.gameObject);
            print("hit");

        }

        if (collision.gameObject.name == "Seesaw")
        {
            Destroy(collision.gameObject);
            print("hit");
            star.SetActive(true);
        }

    }
}