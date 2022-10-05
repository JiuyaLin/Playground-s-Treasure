using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideScrit : MonoBehaviour
{
    public GameManagerScript gameManager;
    public AudioSource audioSource;
    private Rigidbody2D rb;
    public GameObject Square;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Square = GameObject.Find("Square");

    }
    // Update is called once per frame
    void Update()
    {


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "worm")
        {
            print("hit");
            Destroy(Square);




        }
    }

}



