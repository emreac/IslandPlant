using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject head1obj;
    public GameObject head2obj;



 

    public bool head1 = true;
    public bool head2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameComplete();

        
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Head2")
        {
            head2 = true;
            head1obj.SetActive(false);
            head2obj.SetActive(true);


             
        }
    }

    private void GameComplete()
    {
        if (head2)
        {
           
            Debug.Log("Next Level!");
        }
    }
}
