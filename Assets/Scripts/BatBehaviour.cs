using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BatBehaviour : MonoBehaviour
{

    public float Speed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && gameObject.name == "Bat")
        {
            transform.localPosition += Vector3.left * Speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D) && gameObject.name == "Bat")
        {
            transform.localPosition += Vector3.right * Speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name == "Left Wall" && Input.GetKey(KeyCode.A))
        {

            transform.localPosition += Vector3.right * 0.2f * Time.deltaTime;

        }
            
        else if (collision.gameObject.name == "Right Wall" && Input.GetKey(KeyCode.D))
        {

            

        }
    }
}
