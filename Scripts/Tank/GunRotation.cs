using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunRotation : MonoBehaviour
{

    public float Camera_Rotation_Speed;
    public float Turret_Rotation_Speed;
    public float FireRat_e;
    private float FireTime = 2;

    public Slider ReloadSlider;
    public GameObject Shell;
    public GameObject Turret;
    public GameObject Barrel;
    public GameObject Tank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotationFunction();
        Fayya();
        ReloadTime();
    }

    void RotationFunction(){
        float MouseInput_X = Input.GetAxis("Mouse X");
        float MouseInput_Y = Input.GetAxis("Mouse Y");

        float MouseMovement_X = MouseInput_X * Camera_Rotation_Speed;
        float MouseMovement_Y = MouseInput_Y * Camera_Rotation_Speed;
        
        transform.RotateAround(Tank.transform.position, Tank.transform.up, MouseMovement_X);
        
        Turret.transform.rotation = Quaternion.Lerp(Turret.transform.rotation, this.transform.rotation, Turret_Rotation_Speed * Time.deltaTime);
    }

    void Fayya(){
        float Space_input = Input.GetAxis("Jump");
        if(Space_input > 0 && Time.time >= FireTime){
            Debug.Log("Fayya!!!11!111");
            Instantiate(Shell, Barrel.transform.position, Turret.transform.rotation);
            FireTime = Time.time + FireRat_e;
        }
    }

    void ReloadTime(){
        ReloadSlider.maxValue = FireRat_e;
        ReloadSlider.value = FireTime - Time.time;        
    }
}
