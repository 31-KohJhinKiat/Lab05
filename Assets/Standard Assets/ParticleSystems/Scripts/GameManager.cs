using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float scoreValue;
    private float totalCoins;
    public float timeLeft;
    public int timeRemining;

    
    public Text ScoreText;
    public Text TimerText;

    private float TimerValue;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timeRemining = Mathf.FloorToInt(timeLeft % 60);

        TimerText.text = "Timer: " + timeRemining.ToString();

        if(scoreValue == totalCoins)
        {
            if(timeLeft <= TimerValue)
            {
                SceneManager.LoadScene("WinScene");
            }

            else if (timeLeft <= 0)
            {
                SceneManager.LoadScene("LoseScene");

            }

        }

       

    }

    


    }
