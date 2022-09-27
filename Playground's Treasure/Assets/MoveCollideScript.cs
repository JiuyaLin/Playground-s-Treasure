using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollideScript: MonoBehaviour
{
    public float speed;
   
    
    private Vector3 playerVelocity;

    // Start is called before the first frame update
    private void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw(“Horizontal”);
        float v = Input.GetAxisRaw(“Vertical”);

        gameObject.transform.position = new Vector2(transform.position.x + (h * speed),
      transform.position.y + (v * speed));

    }

    


}



