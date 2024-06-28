using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty_accel : MonoBehaviour
{
    public float difficulty = 0.0f;
    public float global_speed = 0.0f;

    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //difficulty = 0.01f;
        //global_speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 1.0f) timer += Time.deltaTime;
        else
        {
            global_speed += difficulty;
            timer = 0.0f;
        }

    }
}
