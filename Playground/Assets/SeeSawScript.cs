using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSawScript : MonoBehaviour
{
    public GameManagerScript gameManager;
    public AudioSource audioSource;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "worm")
        {
            Destroy(this.gameObject);
            print("hit");


            gameManager.wrong.Play();

        }
    }
}
