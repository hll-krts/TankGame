using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_script : MonoBehaviour
{
    //public GunRotation TargetCounter;

    //private float Counter;
    // Start is called before the first frame update
    void Start()
    {
        //Counter = TargetCounter.Target_Count;
    }

    // Update is called once per frame
    void Update()
    {
        //TargetCounter.Target_Count = Counter;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Ammo"){
            //Counter++;
            GameObject.FindObjectOfType<GunRotation>().Target_Count+=1;
            Debug.Log(GameObject.FindObjectOfType<GunRotation>().Target_Count);

            Destroy(this.gameObject);
        }

    }
}
