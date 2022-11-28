using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    bool Pause_control_bool = false;
    public float Esc_key = 0;
    
    public GameObject HUD;
    public GameObject PauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.GetComponent<Canvas>().enabled = false;
        HUD.GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();        
        
    }

    void PauseGame(){
        Esc_key = Input.GetAxis("Cancel");
        Debug.Log(Esc_key);
        if(Esc_key <= 1 && Esc_key>=0){
            if(Esc_key>0.1f && Pause_control_bool == false){
                PauseMenu.GetComponent<Canvas>().enabled = !PauseMenu.GetComponent<Canvas>().enabled;
                HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
                Pause_control_bool = true;
                Time.timeScale = 0.000000000001f;
            }
            if(Esc_key==0.0f && Pause_control_bool == true){
                Pause_control_bool = false;
            }
        }
        else{
            Esc_key = 0;
        }
    }
    public void Continue_Button(){
        Esc_key = 0;
        PauseMenu.GetComponent<Canvas>().enabled = !PauseMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        Time.timeScale = 1.0f;
    }
}
