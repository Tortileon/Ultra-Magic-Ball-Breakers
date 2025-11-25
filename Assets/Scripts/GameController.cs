using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject blocker;
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

    public void PlayerLives()
    {
      int lives = 3;

        if (lives <= 0)
        {
            Debug.Log("dead skull lol");
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
            Debug.Log("something is wrong");
        }
    }
}
