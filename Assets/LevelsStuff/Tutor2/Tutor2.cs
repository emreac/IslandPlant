using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor2 : MonoBehaviour
{
    public GameObject tutor2Canvas;
    public GameObject jumpButtonTutor;
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
            tutor2Canvas.gameObject.SetActive(true);
            jumpButtonTutor.gameObject.SetActive(true);
            Time.timeScale = 0.2f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutor2Canvas.gameObject.SetActive(false);
            jumpButtonTutor.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
