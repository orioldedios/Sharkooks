using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer = 0.0f;
    
    public float spawn_time = 5.0f;
    public GameObject body_to_spawn = null;

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
            timer = 0.0f;
            GameObject new_object = Instantiate(body_to_spawn, transform.position, Quaternion.identity);
        }
    }
}
