using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    #region Singleton

    private static Score _instance = null;

    public static Score Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Score>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: ScoreManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    private static int highScore;
    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }

    private int currentScore;

    //public float score = 0;
    //public Text scoreUI;
    public Spawn SpawnObject;

    // Start is called before the first frame update
    void Start()
    {
        ResetCurrentScore();
    }
    public void ResetCurrentScore()
    {
        currentScore = 0;
    }
    // Update is called once per frame
    public void IncrementCurrentScore(int tileCount, int comboCount)
    {
        
        currentScore += 1;

    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("kotak"))
        {
            
            StartCoroutine(SpawnObject.SpawnObject());
            currentScore += 1;

            if (currentScore > highScore)
            {
                highScore = currentScore;
            }
            //Debug.Log(currentScore);
            //score += 1;
            //scoreUI.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
    public void SetHighScore()
    {
        //Debug.Log("masuk highscore cok");
        if (currentScore > highScore)
        {
            //Debug.Log("masuk if highscore cok");
            highScore = currentScore;
        }
    }
}
