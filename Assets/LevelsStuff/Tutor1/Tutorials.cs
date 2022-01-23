using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public GameObject tutor1Text;
    public GameObject tutor1RButton;


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
            tutor1Text.gameObject.SetActive(true);
            Time.timeScale = 0.2f;
            tutor1RButton.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutor1RButton.gameObject.SetActive(false);
            tutor1Text.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
