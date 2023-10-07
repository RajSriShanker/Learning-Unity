using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PongScoreController : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;

    public GameObject pongBall;

    private void Awake()
    {
        pongBall = GameObject.Find("Pong Ball");
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScoreText.text = pongBall.GetComponent<PongBallController>().playerScore.ToString();
        enemyScoreText.text = pongBall.GetComponent<PongBallController>().enemyScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        playerScoreText.text = pongBall.GetComponent<PongBallController>().playerScore.ToString();
        enemyScoreText.text = pongBall.GetComponent<PongBallController>().enemyScore.ToString();
    }
}
