using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class GameSession : MonoBehaviour {

    // config params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    //[SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] public bool isAutoPlayEnabled;

    // state variables
    [SerializeField] int currentScore = 0;

    public static GameSession gameSession; 

    public void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            //gameSession = FindObjectOfType<GameSession>();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            gameSession = this;
        }
    }

    private void Start()
    {
        //scoreText.text = currentScore.ToString();    
    }

    // Update is called once per frame
    void Update () {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        //scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
