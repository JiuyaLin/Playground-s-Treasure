using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollideScript: MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;

    }

    void OnCollisionEnter2D()
    {
        Debug.Log("player collided with something");
        StartCoroutine(pauseSound());

    }


    
    IEnumerator pauseSound()
    {
        yield return new WaitForSeconds(1);
        //sound code
        Debug.Log("play sound");
    }

}



