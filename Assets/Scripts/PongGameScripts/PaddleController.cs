using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D playerPaddleRB;

    [SerializeField] private float moveSpeed = 10f;

    private void Awake()
    {
        playerPaddleRB = GetComponent<Rigidbody2D>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        PaddleMovement();
    }

    private void PaddleMovement()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        playerPaddleRB.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}
