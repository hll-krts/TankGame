using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{

    public float Camera_Rotation_Speed;

    public GameObject Turret;
    public GameObject Barrel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseInput_X = Input.GetAxis("Mouse X");
        float MouseInput_Y = Input.GetAxis("Mouse Y");

        float MouseMovement_X = MouseInput_X * Camera_Rotation_Speed;
        float MouseMovement_Y = MouseInput_Y * Camera_Rotation_Speed;

        Turret_Control();
        transform.RotateAround(Turret.transform.position, Turret.transform.up, MouseMovement_X);

    }

    void Turret_Control(){

        

    }
}
