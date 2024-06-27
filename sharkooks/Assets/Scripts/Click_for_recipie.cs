using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_for_recipie : MonoBehaviour
{
    public GameObject recipie_manager = null;
    public Recipie_Logic recipie_Logic_Script = null;

    // Start is called before the first frame update
    void Start()
    {
        recipie_manager = GameObject.Find("Recipie_UX");
        recipie_Logic_Script = recipie_manager.GetComponent<Recipie_Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.name == recipie_Logic_Script.show_face.GetComponent<SpriteRenderer>().sprite.name)
                {
                    recipie_Logic_Script.face_got_it = true;
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.name == recipie_Logic_Script.show_body.GetComponent<SpriteRenderer>().sprite.name)
                {
                    recipie_Logic_Script.body_got_it = true;
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.name == recipie_Logic_Script.show_legs.GetComponent<SpriteRenderer>().sprite.name)
                {
                    recipie_Logic_Script.legs_got_it = true;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
