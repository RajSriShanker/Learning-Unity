using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallController : MonoBehaviour
{
    private Rigidbody2D pongBallRB;

    [SerializeField] private float moveSpeed = 10f;

    public float playerScore = 0f;
    public float enemyScore = 0f;

    private void Awake()
    {
        pongBallRB = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Launch()
    { 
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        pongBallRB.velocity = new Vector2(moveSpeed * x, moveSpeed * y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player Boundary"))
        {
            enemyScore++;
            transform.position = new Vector2(0, 0);
            pongBallRB.velocity = new Vector2(0, 0);
            Launch();
        }
        else if (collision.gameObject.CompareTag("Enemy Boundary"))
        {
            playerScore++;
            transform.position = new Vector2(0, 0);
            pongBallRB.velocity = new Vector2(0, 0);
            Launch();
        }
    }
}
