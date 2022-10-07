using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovalScript1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject[] Elim;

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
            Elim = GameObject.FindGameObjectsWithTag("Round1");
            foreach (GameObject elim in Elim) //destroy each varible in Elim
            {
                Destroy(elim);
            }

            Destroy(this.gameObject);

        }
    }
}
