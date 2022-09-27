using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollideScript: MonoBehaviour
{
    public float speed;
   

    

    // Start is called before the first frame update
    private void Start()
    {
        

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

    


}



