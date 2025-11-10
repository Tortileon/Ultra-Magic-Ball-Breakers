using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    public int purplecount = 0;
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
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Ball" && gameObject.tag == "PurpleBrick")
        {
            purplecount += 1;

            if (purplecount == 2)
            {
                Destroy(this.gameObject);
                purplecount = 0;
                Debug.Log(purplecount);
            }

            
        }
    }
}
