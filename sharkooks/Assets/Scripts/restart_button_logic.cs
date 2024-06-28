using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_button_logic : MonoBehaviour
{
    public GameObject button_go = null;

    // Start is called before the first frame update
    void Start()
    {
        button_go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<SpriteRenderer>().enabled)
        {
            button_go.SetActive(true);
        }

    }

    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
