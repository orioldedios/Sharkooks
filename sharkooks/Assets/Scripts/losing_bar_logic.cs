using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losing_bar_logic : MonoBehaviour
{
    public float speed = 0.5f;
    public float losing_number = 6.5f;
    public GameObject you_lose_game_object = null;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.0f, transform.localScale.y, transform.localScale.z);
        you_lose_game_object.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.localScale.x >= losing_number)
        {
            you_lose_game_object.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x + speed * Time.deltaTime, transform.localScale.y, transform.localScale.z);
        }
    }
}
