using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public GameObject blocker;
    public TextMeshProUGUI scoreText;
    public int score = 0;
    void Start()
    {
        
    }

    
    void Update()
    { 
        if (Input.GetKey(KeyCode.Return))
        {
            StartGame();
        }
    }
    public void IncreaseScore()
    {
        score += 50;
        string scoretostring = score.ToString();
        scoreText.text = scoretostring;
        Debug.Log(score); // for each time a brick is destroyed add 50 to the score and convert that value into a string to display in the tmp textbox
    }

    public int GetScore()
    {
        return score; // returns score
    }
    public void PlayerLives()
    {
      int lives = 3;

        if (lives <= 0)
        {
            Debug.Log("dead");  // does not function
        }
    }

    public void StartGame()
    {
        if (blocker != null)
        {
            blocker.SetActive(false);
        }
        else
        {
            Debug.Log("something is wrong"); // if there is an object in the blocker field then set it to false when enter is hit, else display this message
        }
    }
}
