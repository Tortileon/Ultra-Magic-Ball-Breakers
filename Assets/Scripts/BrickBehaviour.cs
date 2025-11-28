using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BrickBehaviour : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameController gamecontroller;
    public GameObject Hitfx;

    public int purplecount = 0; //declaring brick health/count variables.
    public int greencount = 0;
    public int bluecount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hitfx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   async private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball" && gameObject.tag == "RedBrick")
        {
            Destroy(this.gameObject);  //destroys brick after collision
            gamecontroller.IncreaseScore(); // increases score by 50 in the game controller script
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "PurpleBrick")
        {
            purplecount += 1;
            Hitfx.SetActive(true);
            await Task.Delay(100);
            Hitfx.SetActive(false); // deals damage to the brick and shows the damage effect

            if (purplecount == 2)
            {
                Destroy(this.gameObject);
                gamecontroller.IncreaseScore(); // increases score by 50 in the game controller script
                purplecount = 0;
                //destroys purple brick after 2 hits and resets purple count
            }

            
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "GreenBrick")
        {
            greencount += 1;
            Hitfx.SetActive(true);
            await Task.Delay(100);
            Hitfx.SetActive(false); // deals damage to the brick and shows the damage effect

            if (greencount == 3)
            {

                Destroy(this.gameObject);
                gamecontroller.IncreaseScore(); // increases score by 50 in the game controller script
                greencount = 0; //destroys green brick after 3 hits and resets greencount
            }
            
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "BlueBrick")
        {
            bluecount += 1;
            Hitfx.SetActive(true);
            await Task.Delay(100);
            Hitfx.SetActive(false); // deals damage to the brick and shows the damage effect

            if (bluecount == 5)
            {
                Destroy(this.gameObject);
                gamecontroller.IncreaseScore(); // increases score by 50 in the game controller script
                bluecount = 0;  //destroys blue brick after 5 hits and resets bluecount
            }

        }
    } 
}
