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
            GameObject.FindObjectOfType<GunRotation>().ScoreChanger();

            Destroy(this.gameObject);
        }

    }
}
