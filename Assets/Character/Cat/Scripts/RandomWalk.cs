using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float range;
    [SerializeField] float maxDistance;
    private float cooldown = 5.0f;
    Vector2 wayPoint;
    Vector2 prevWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        newRandomDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            cooldown -= Time.deltaTime;

            if (cooldown < 1)
            {
                prevWayPoint = wayPoint;
                newRandomDestination();

                cooldown = 5.0f;
            }
        }
    }

    void newRandomDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), -0.574f);
    }
}
