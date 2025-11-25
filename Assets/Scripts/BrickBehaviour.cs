using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    public int purplecount = 0; //declaring brick health/count variables.
    public int greencount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball" && gameObject.tag == "RedBrick")
        {
            Destroy(this.gameObject);  //destroys brick after collision
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "PurpleBrick")
        {
            purplecount += 1;

            if (purplecount == 2)
            {
                Destroy(this.gameObject);
                purplecount = 0;
                Debug.Log(purplecount); //destroys purple brick after 2 hits and resets purple count
            }

            
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "GreenBrick")
        {
            greencount += 1;

            if (greencount == 3)
            {
                Destroy(this.gameObject);
                greencount = 0;
            }
            
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "BlueBrick")
        {
            greencount += 1;

            if (greencount == 5)
            {
                Destroy(this.gameObject);
                greencount = 0;
            }

        }
    } // hi
}
