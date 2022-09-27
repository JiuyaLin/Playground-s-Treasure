using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollideScript: MonoBehaviour
{
    public float speed;
    private Vector direction = Vector2.zero;

    

    // Start is called before the first frame update
    private void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        

        gameObject.transform.position = new Vector2(transform.position.x + (h * speed),
      transform.position.y + (v * speed));

    }

    


}



