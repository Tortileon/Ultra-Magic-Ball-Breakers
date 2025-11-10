using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PbrickSpawner : MonoBehaviour
{
    public BrickBehaviour pbrick;
    public BrickBehaviour[] pbrickClones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pbrickClones = new BrickBehaviour[7];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //spawns bricks when enter is pressed
        {
            for (int i = 0; i < pbrickClones.Length; i++)
            {
                SpawnPBrick();

            }
        }


        else if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < pbrickClones.Length; i++)
            {
                if (pbrickClones[i] != null)
                    Destroy(pbrickClones[i].gameObject);
                pbrickClones[i] = null; // 28 - 34 destroys all arrayed bricks once space is pressed.
            }
        }
    }

    void SpawnPBrick() //method that spawns bricks
    {
        float setamount = 2f; // setup for spawn distance per brick
        Vector3 pos = transform.position;
        Vector3 oldpos = transform.position;

        for (int i = 0; i < pbrickClones.Length; i++)
        {
            if (pbrickClones[i] == null) // if the index is an empty slot
            {
                pbrickClones[i] = Instantiate(pbrick); // create a new purplebrick
                pos.x += setamount;
                transform.position = pos;
                pbrickClones[i].transform.position = transform.position; // 49,50,51 move new brick 1 space ahead of previous brick
                pbrickClones[i].gameObject.SetActive(true); // do i need this?
                return; // stop once we've filled one slot
            }
        }

        oldpos.x = -8;
        transform.position = oldpos;

        Debug.Log("Array is full! No more bricks.");

    } // NOTE: MAKE A NEW SCRIPT CALLED PBRICKSPAWNER AND COPY ALL THE PBRICKSPAWNER CODE FROM HERE INTO THERE TYSM!
}

