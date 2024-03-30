using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    [SerializeField] private GameObject square;
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float stoppingDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, square.transform.position);

        if (distance > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, square.transform.position, speed * Time.deltaTime);
            transform.right = square.transform.position - transform.position;
        }
        
    }
}
