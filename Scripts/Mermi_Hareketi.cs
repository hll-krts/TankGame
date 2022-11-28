using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi_Hareketi : MonoBehaviour
{
    //target count artmıyor
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        Destroy(this.gameObject, 0.8f);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Target"){
            Destroy(this.gameObject);
        }
        if(other.tag == "Cover"){
            Debug.Log("Cover");
            Destroy(this.gameObject);
        }
    }
}
