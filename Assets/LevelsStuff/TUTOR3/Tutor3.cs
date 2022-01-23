using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor3 : MonoBehaviour
{
    public GameObject tutor3Canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            tutor3Canvas.gameObject.SetActive(true);
            Time.timeScale = 0.2f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutor3Canvas.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }

    }
}
