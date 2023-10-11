using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallController : MonoBehaviour
{
    private Rigidbody2D pongBallRB;

    [SerializeField] private float ballLaunchDelay = 1f;
    [SerializeField] private float moveSpeed = 10f;

    public float playerScore = 0f;
    public float enemyScore = 0f;

    [SerializeField] private AudioSource hitSoundEffect;
    [SerializeField] private AudioSource failSoundEffect;
    [SerializeField] private AudioSource scoreSoundEffect;

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
            failSoundEffect.Play();
            transform.position = new Vector2(0, 0);
            pongBallRB.velocity = new Vector2(0, 0);
            Invoke("Launch", ballLaunchDelay);
        }
        else if (collision.gameObject.CompareTag("Enemy Boundary"))
        {
            playerScore++;
            scoreSoundEffect.Play();
            transform.position = new Vector2(0, 0);
            pongBallRB.velocity = new Vector2(0, 0);
            Invoke("Launch", ballLaunchDelay);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            hitSoundEffect.Play();
        }
    }
}
