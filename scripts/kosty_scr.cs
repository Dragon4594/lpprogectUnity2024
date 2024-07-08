using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kosty_scr : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    //public Transform cub;
    //public Transform cub1;
    //private Transform platform;
    
    //public Transform voil;
    [Header("чувствительность мыши")]
    public float sM = 0.5f;
   /* void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // disable
                rigidbody.enabled = false;

    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){ 
        Cursor.lockState = CursorLockMode.Locked;
        mouseX = Input.GetAxis("Mouse X") * sM * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sM * Time.deltaTime;
        transform.localPosition += transform.right*mouseX;
        transform.localPosition += transform.forward*mouseY;
        }
        /*cub.Rotate(mouseX * new Vector3(0, 1, 0));
        cub.Rotate(mouseY * new Vector3(1, 0, 0));
        cub1.Rotate(mouseX * new Vector3(0, 1, 0));
        cub1.Rotate(mouseY * new Vector3(1, 0, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        transform.Rotate(-mouseX * new Vector3(0, 1, 0));
        

       
        /*if ((mouseY >= -90.0) && (mouseY <= 90.0) && !(Input.GetKey(KeyCode.R)))
        {
            transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(180 * new Vector3(0, 1, 0));
        }
            if (Input.GetKeyUp(KeyCode.R))
        {
            transform.Rotate(180 * new Vector3(0, 1, 0));
        }*/
        /*}
        if  (Input.GetKey(KeyCode.S)){
                //Cursor.lockState = CursorLockMode.Locked;
                Cursor.lockState = CursorLockMode.None;
                
 
                // enable
               // rigidbody.enabled = true;
 
                // disable
                //rigidbody.enabled = false;
        }*/
        
    }
}
