using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    [SerializeField] private GameObject animal;
    [SerializeField] private float stoppingDistance = 0.1f;
    private bool left = true;
    private float cooldown = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, animal.transform.position);

        if (distance < stoppingDistance)
        {
            cooldown -= Time.deltaTime;

            if (cooldown < 1)
            {
                if (transform.position.x <= 0.2 && transform.position.x >= -0.2)
                {

                    if (left)
                    {
                        left = false;
                        transform.position = new Vector2(-0.578f, -0.133f);
                        cooldown = 5.0f;
                    }

                    else
                    {
                        left = true;
                        transform.position = new Vector2(0.578f, -0.133f);
                        cooldown = 5.0f;
                    }
                }

                else
                {
                    transform.position = new Vector2(0.0f, -0.133f);
                    cooldown = 5.0f;
                }
            }
        }
    }
}
