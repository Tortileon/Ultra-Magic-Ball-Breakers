using UnityEngine;

public class BbrickSpawner : MonoBehaviour
{
    public BrickBehaviour bbrick;
    public BrickBehaviour[] bbrickClones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bbrickClones = new BrickBehaviour[3];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //spawns bricks when enter is pressed
        {
            for (int i = 0; i < bbrickClones.Length; i++)
            {
                SpawnPBrick();

            }
        }


        else if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < bbrickClones.Length; i++)
            {
                if (bbrickClones[i] != null)
                    Destroy(bbrickClones[i].gameObject);
                bbrickClones[i] = null; // 28 - 34 destroys all arrayed bricks once space is pressed.
            }
        }
    }

    void SpawnPBrick() //method that spawns bricks
    {
        float setamount = 4f; // setup for spawn distance per brick
        Vector3 pos = transform.position;
        Vector3 oldpos = transform.position;

        for (int i = 0; i < bbrickClones.Length; i++)
        {
            if (bbrickClones[i] == null) // if the index is an empty slot
            {
                bbrickClones[i] = Instantiate(bbrick); // create a new purplebrick
                pos.x += setamount;
                transform.position = pos;
                bbrickClones[i].transform.position = transform.position; // 49,50,51 move new brick 1 space ahead of previous brick
                bbrickClones[i].gameObject.SetActive(true); // do i need this?
                return; // stop once we've filled one slot
            }
        }

        oldpos.x = -8;
        transform.position = oldpos; // tries to reset the brick spawner to it's original position after it's gone through the array

        Debug.Log("Array is full! No more bricks.");

    }
}