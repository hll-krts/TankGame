using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_script : MonoBehaviour
{
    public GameObject BasicTarget;
    public GameObject BasicTarget_Container;

    private bool haveTime = true;
    //float Target_Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BasicTargetSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time == 30.0f){
            gamestop();
        }
    }

    IEnumerator BasicTargetSpawner(){
        while(haveTime){
            Vector3 position = new Vector3(Random.Range(-95, 95), 1.55f, Random.Range(-95, 95));
            GameObject Parent_BTarget = Instantiate(BasicTarget, position, Quaternion.identity);
            Parent_BTarget.transform.parent = BasicTarget_Container.transform;
            yield return new WaitForSeconds(10.0f);
        }
    }
    void gamestop(){
        
            haveTime = false;
            Time.timeScale = 0.1f;
    }
}
