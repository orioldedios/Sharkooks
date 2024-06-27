using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_Movement : MonoBehaviour
{
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (transform.position.y < -6.0f) Destroy(this.gameObject);
    }
}
