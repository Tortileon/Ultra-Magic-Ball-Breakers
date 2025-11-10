using UnityEngine;
using UnityEngine.WSA;

public class BallBehaviour : MonoBehaviour
{

    public float speed = 2.0f;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        direction = new Vector2(1, 1).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object in the current direction
        transform.position += speed * Time.deltaTime * (Vector3)direction; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the normal vector of the surface the object collided with
        Vector2 surfaceNormal = collision.contacts[0].normal;

        // Calculate the reflected direction vector
        direction = Vector2.Reflect(direction, surfaceNormal);

        if (collision.gameObject.name == "Spikes")
        {

            Destroy(this.gameObject);

        }
    }

    
}
