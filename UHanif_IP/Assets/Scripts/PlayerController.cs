using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.back * Time.deltaTime * 4 * horizontalInput); //left and right
        transform.Translate(Vector3.right * Time.deltaTime * 4 * verticalInput); // forward and back
      
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");// * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);
    }
}
