using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public BrickBehaviour brick;
    public BrickBehaviour[] brickClones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        brickClones = new BrickBehaviour[16];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //spawns bricks when enter is pressed
        {
            for (int i = 0; i < brickClones.Length; i++)
            {
                SpawnBrick();
            }
        }


        else if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < brickClones.Length; i++)
            {
                if (brickClones[i] != null)
                    Destroy(brickClones[i].gameObject);
                brickClones[i] = null; // 28 - 34 destroys all arrayed bricks once space is pressed.
            }
        }
    }

    void SpawnBrick() //method that spawns bricks
    {
        float setamount = 1f; // setup for spawn distance per brick
        Vector3 pos = transform.position;
        Vector3 oldpos = transform.position;

        for (int i = 0; i < brickClones.Length; i++)
        {
            if (brickClones[i] == null) // if the index is an empty slot
            {
                brickClones[i] = Instantiate(brick); // create a new redbrick
                pos.x += setamount;
                transform.position = pos;
                brickClones[i].transform.position = transform.position; // 49,50,51 move new brick 1 space ahead of previous brick
                brickClones[i].gameObject.SetActive(true); // do i need this?
                return; // stop once we've filled one slot
            }
        }

        oldpos.x = -9;
        transform.position = oldpos;

        Debug.Log("Array is full! No more bricks.");

    }
}
