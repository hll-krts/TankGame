using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed;
    public float RotationSpeed;
    public float Health;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveFunction();
    }    

    void MoveFunction(){
        float hroizontal_Input = Input.GetAxis("Horizontal");
        float vretical_Input = Input.GetAxis("Vertical");

        float Hroizontal_Rotation = hroizontal_Input * RotationSpeed * Time.deltaTime;
        float Vretical_Movement = vretical_Input * speed * Time.deltaTime;

        transform.position = transform.position + transform.forward * Vretical_Movement;
        transform.rotation = transform.rotation * Quaternion.Euler(0, Hroizontal_Rotation, 0);
    }
}
