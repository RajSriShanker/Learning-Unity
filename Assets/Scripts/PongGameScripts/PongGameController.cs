using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PongGameController : MonoBehaviour
{
    public static PongGameController instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnHome()
    {
        SceneManager.LoadScene("MainScene");
    }
}
