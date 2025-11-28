using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallBehaviour : MonoBehaviour
{

    public float speed = 3.0f;
    private Vector2 direction;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randintx = Random.Range(-1, 1);
        int randinty = Random.Range(1, 2);
        direction = new Vector3(randintx, randinty).normalized; // initial ball trajectory is randomised here
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object in the current direction
        transform.position += speed * Time.deltaTime * (Vector3)direction; 
    }

    async private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the normal vector of the surface the object collided with
        Vector2 surfaceNormal = collision.contacts[0].normal;

        // Calculate the reflected direction vector
        direction = Vector2.Reflect(direction, surfaceNormal);

        if (collision.gameObject.name == "Spikes")
        {

            Destroy(this.gameObject);
            await Task.Delay(1000);
            SceneManager.LoadScene("Game Over"); // if ball touches the spikes the game pauses for a second and moves you to the game over screen



        }
    }

    
}
