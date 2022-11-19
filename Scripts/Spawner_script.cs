using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_script : MonoBehaviour
{
    public GameObject BasicTarget;
    public GameObject BasicTarget_Container;

    private bool haveTime = false;
    //float Target_Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BasicTargetSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if(Time.time >= 600.0f && Time.time <= 600.1f){
            Debug.Log("LIGMA BALLS");
            gamestop();
        }
    }

    IEnumerator BasicTargetSpawner(){
        while(haveTime == false){
            Vector3 position = new Vector3(Random.Range(-95, 95), 1.55f, Random.Range(-95, 95));
            GameObject Parent_BTarget = Instantiate(BasicTarget, position, Quaternion.identity);
            Parent_BTarget.transform.parent = BasicTarget_Container.transform;
            yield return new WaitForSeconds(10.0f);
        }
    }
    void gamestop(){        
            haveTime = true;
            //Time.timeScale = 0.000001f;
    }
}
