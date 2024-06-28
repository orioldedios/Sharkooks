using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer = 0.0f;
    private GameObject body_iterator = null;
    private int random_iterator = 1;
    private int previous_random_iterator = 0;

    public bool body_1_spawned = false;
    public bool body_2_spawned = false;
    public bool body_3_spawned = false;

    public float spawn_time = 5.0f;
    public int Spawner_offset = 1;
    public GameObject body_to_spawn_1 = null;
    public GameObject body_to_spawn_2 = null;
    public GameObject body_to_spawn_3 = null;

    // Start is called before the first frame update
    void Start()
    {
        random_iterator = 1 + Spawner_offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_time) timer += Time.deltaTime;
        else
        {
            //do
            //{
            //    random_iterator = Random.Range(1, 4);
            //} while (random_iterator == previous_random_iterator);

            //if (body_1_spawned && body_2_spawned) random_iterator = 3;
            //if (body_2_spawned && body_3_spawned) random_iterator = 1;
            //if (body_3_spawned && body_1_spawned) random_iterator = 2;

            if (random_iterator < 3) random_iterator += 1;
            else random_iterator = 1;

            switch (random_iterator)
            {
                case 1:
                    body_iterator = body_to_spawn_1;
                    //body_1_spawned = true;
                    break;
                case 2:
                    body_iterator = body_to_spawn_2;
                    //body_2_spawned = true;
                    break;
                case 3:
                    body_iterator = body_to_spawn_3;
                    //body_3_spawned = true;
                    break;
            }

            //if (body_3_spawned && body_1_spawned && body_2_spawned) body_3_spawned = body_2_spawned = body_1_spawned = false;

            //previous_random_iterator = random_iterator;

            timer = 0.0f;

            if (spawn_time > 1.0f) spawn_time -= (0.05f);


            GameObject new_object = Instantiate(body_iterator, transform.position, Quaternion.identity);
        }
    }
}
