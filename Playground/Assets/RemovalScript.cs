using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RemovalScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool objectAllErased;

    public GameObject[] Elim;
    public GameObject[] gone;
    public bool Erased()
    {

        //checks to see if all squares are gone
        //look for objects in array
        for (int i = 0; i < gone.Length; i++)
        {
            //check if object is in scene 
            if (gone[i] != null)
            {
                return false;


            }

        }

        return true;

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        objectAllErased = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (objectAllErased)
        {
            StopCoroutine(waiting());
            Debug.Log("end reached");
            SceneManager.LoadScene("End");

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "worm")
        {
            Elim = GameObject.FindGameObjectsWithTag("Round1");
            Debug.Log("Round1 " + Elim.Length);
            if (Elim.Length > 0)
            {
                Debug.Log("round 1 destroyed");
                destroyListElim();
            }
            else {
                Elim = GameObject.FindGameObjectsWithTag("Round2");
                Debug.Log("Round2 " + Elim.Length);
                if (Elim.Length > 0)
                {
                    Debug.Log("round 2 destroyed");
                    destroyListElim();
                }
                else
                {
                    Elim = GameObject.FindGameObjectsWithTag("Round3");
                    Debug.Log("Round3 " + Elim.Length);
                    if (Elim.Length > 0)
                    {
                        Debug.Log("round 3 destroyed");
                        destroyListElim();
                    }
                    else
                    {
                        Elim = GameObject.FindGameObjectsWithTag("Round4");
                        Debug.Log("Round4 " + Elim.Length);
                        if (Elim.Length > 0)
                        {
                            Debug.Log("round 4 destroyed");
                            destroyListElim();
                        }
                        else
                        {
                            Elim = GameObject.FindGameObjectsWithTag("Round5");
                            Debug.Log("Round5 " + Elim.Length);
                            Debug.Log("round 5 destroyed");
                            destroyListElim();
                            StartCoroutine(waiting());

                        }

                    }
                }

            }

        }
    }

    

    IEnumerator waiting()
    {   
        objectAllErased = true;
        yield return new WaitForSeconds(5);
        
    }


    private void destroyListElim()
    {
        foreach (GameObject elim in Elim) //destroy each varible in Elim
        {
            Destroy(elim);
        }
        Destroy(this.gameObject);
        Elim = null;
    }

    

}


