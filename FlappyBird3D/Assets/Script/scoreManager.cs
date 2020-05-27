using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    
    public Transform player;
    public static float score = 0;
    public Text scoreText;


    public Text HighScore;

    void Start()
    {
        score = 0;
    }


    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = score.ToString();
    }
}
