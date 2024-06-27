using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer = 0.0f;
    private GameObject body_iterator = null;
    private int random_iterator = 1;
    private int previous_random_iterator = 0;

    public float spawn_time = 5.0f;
    public GameObject body_to_spawn_1 = null;
    public GameObject body_to_spawn_2 = null;
    public GameObject body_to_spawn_3 = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_time) timer += Time.deltaTime;
        else
        {
            do
            {
                random_iterator = Random.Range(1, 4);
            } while (random_iterator == previous_random_iterator);

            switch (random_iterator)
            {
                case 1:
                    body_iterator = body_to_spawn_1;
                    break;
                case 2:
                    body_iterator = body_to_spawn_2;
                    break;
                case 3:
                    body_iterator = body_to_spawn_3;
                    break;
            }

            previous_random_iterator = random_iterator;

            timer = 0.0f;
            GameObject new_object = Instantiate(body_iterator, transform.position, Quaternion.identity);
        }
    }
}
