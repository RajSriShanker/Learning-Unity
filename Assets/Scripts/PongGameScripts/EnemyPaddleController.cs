using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    private Rigidbody2D enemyPaddleRB;
    private GameObject ball;

    [SerializeField] private float moveSpeed = 10f;

    void Awake()
    {
        enemyPaddleRB = GetComponent<Rigidbody2D>();
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        EnemyPaddleMovement();
    }

    private void EnemyPaddleMovement()
    { 
        if (ball != null)
        {
            if (ball.transform.position.y > transform.position.y)
            {
                //Move smoothly towards the ball by using Lerp
                enemyPaddleRB.velocity = new Vector2(0, Mathf.Lerp(enemyPaddleRB.velocity.y, 1 * moveSpeed, 0.2f));
            }
            else if (ball.transform.position.y < transform.position.y)
            {
                enemyPaddleRB.velocity = new Vector2(0, Mathf.Lerp(enemyPaddleRB.velocity.y, -1 * moveSpeed, 0.2f));
            }
            else
            {
                enemyPaddleRB.velocity = new Vector2(0, 0);
            }
        }

    }
}
