using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Nextlevel()
    {
        SceneManager.LoadScene("Magic Ball Breakers");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartLvl()
    {
        SceneManager.LoadScene("Magic Ball Breakers");
    }
} // all methods to move to a specific scene (restart lvl not needed)
