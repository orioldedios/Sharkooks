﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipie_Logic : MonoBehaviour
{
    public Sprite face_A = null;
    public Sprite face_B = null;
    public Sprite face_C = null;
    public Sprite body_A = null;
    public Sprite body_B = null;
    public Sprite body_C = null;
    public Sprite legs_A = null;
    public Sprite legs_B = null;
    public Sprite legs_C = null;

    public GameObject show_face = null;
    public GameObject show_body = null;
    public GameObject show_legs = null;

    public bool player_got_it = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player_got_it)
        {
            player_got_it = false;

            //face random selection
            int random_face_iterator = Random.Range(1, 4);
            switch (random_face_iterator)
            {
                case 1:
                    show_face.GetComponent<SpriteRenderer>().sprite = face_A;
                    break;
                case 2:
                    show_face.GetComponent<SpriteRenderer>().sprite = face_B;
                    break;
                case 3:
                    show_face.GetComponent<SpriteRenderer>().sprite = face_C;
                    break;
            }

            //body random selection
            int random_body_iterator = Random.Range(1, 4);
            switch (random_body_iterator)
            {
                case 1:
                    show_body.GetComponent<SpriteRenderer>().sprite = body_A;
                    break;
                case 2:
                    show_body.GetComponent<SpriteRenderer>().sprite = body_C;
                    break;
                case 3:
                    show_body.GetComponent<SpriteRenderer>().sprite = body_C;
                    break;
            }

            //legs random selection
            int random_legs_iterator = Random.Range(1, 4);
            switch (random_legs_iterator)
            {
                case 1:
                    show_legs.GetComponent<SpriteRenderer>().sprite = legs_A;
                    break;
                case 2:
                    show_legs.GetComponent<SpriteRenderer>().sprite = legs_B;
                    break;
                case 3:
                    show_legs.GetComponent<SpriteRenderer>().sprite = legs_B;
                    break;
            }

        }
    }
}