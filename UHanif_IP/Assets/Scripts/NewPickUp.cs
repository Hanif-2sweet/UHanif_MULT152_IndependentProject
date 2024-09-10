using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPickUp : MonoBehaviour
{
      public GameObject ScannerOnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        ScannerOnPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                ScannerOnPlayer.SetActive(true);
             
            }

        }
    }


}
