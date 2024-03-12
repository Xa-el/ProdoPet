using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public float speed = 5f;
    public float movespeed = 0.1f;
    public float movementTime = 10f;
    public float currTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movementTime -= Time.deltaTime;
        if (movementTime >= 0)
        { 
                //transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
                transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
        }
        
    }
}
