using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_Movement : MonoBehaviour
{
    public float speed = 0.5f;
    public float wrong_penalty = 0.8f;
    public GameObject bar_go = null;
    public GameObject game_manager = null;


    // Start is called before the first frame update
    void Start()
    {
        bar_go = GameObject.Find("bar");
        game_manager = GameObject.Find("Game_Manager");
        wrong_penalty = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (transform.position.y < -6.0f)
        {
            bar_go.transform.localScale = new Vector3(bar_go.transform.localScale.x + wrong_penalty, bar_go.transform.localScale.y, bar_go.transform.localScale.z);
            Destroy(this.gameObject);
        }

        
        if(speed > 0) speed = game_manager.GetComponent<difficulty_accel>().global_speed;
        else speed = game_manager.GetComponent<difficulty_accel>().global_speed * (-1);

    }
}
