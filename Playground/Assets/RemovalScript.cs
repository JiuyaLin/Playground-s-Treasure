using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovalScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Square;
    public GameObject SecondSquare;
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
            print("hit");
            Destroy(Square);
            Destroy(this.gameObject);
            Destroy(SecondSquare);



        }
    }
}
