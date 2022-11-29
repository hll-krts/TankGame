using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    bool Pause_control_bool = false;
    bool Level_up_menu_control_bool = false;
    public float Esc_key = 0;
    
    public GameObject HUD;
    public GameObject PauseMenu;
    public GameObject LevelUpMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.GetComponent<Canvas>().enabled = false;
        HUD.GetComponent<Canvas>().enabled = true;
        LevelUpMenu.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();        
        Level_up_menu();
    }

    void PauseGame(){
        Esc_key = Input.GetAxis("Cancel");
        //Debug.Log(Esc_key);
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
        //duraklatma menüsü açıldıktan sonra devam et tuşunun oyunu devam ettirmesi
        Esc_key = 0;
        PauseMenu.GetComponent<Canvas>().enabled = !PauseMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        Time.timeScale = 1.0f;
    }
    void Level_up_menu(){
        //seviye atlama menüsünü açma ve sonraki seviyeler için ayarlama
        float Is_Level_up = GameObject.FindObjectOfType<GunRotation>().Target_Count;
        if(Is_Level_up > 0 && Is_Level_up % 5 == 0 && Level_up_menu_control_bool == false){
            LevelUpMenu.GetComponent<Canvas>().enabled = !LevelUpMenu.GetComponent<Canvas>().enabled;
            HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
            Level_up_menu_control_bool = true;
            Time.timeScale = 0.000000000001f;
        }
        if(Is_Level_up % 5 != 0 && Level_up_menu_control_bool == true){
            Level_up_menu_control_bool = false;
        }
    }
    public void ImproveDamageFunction(){
        //hasarı %15 artırma
        GameObject.FindObjectOfType<GunRotation>().Damage = GameObject.FindObjectOfType<GunRotation>().Damage * 1.15f;
        LevelUpMenu.GetComponent<Canvas>().enabled = !LevelUpMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        //Level_up_menu_control_bool = true;
        Time.timeScale = 1.0f;
        Debug.Log(GameObject.FindObjectOfType<GunRotation>().Damage + "     "+Level_up_menu_control_bool);
    }
    public void ImproveSpeedFunction(){
        //hızı %15 artırma
        GameObject.FindObjectOfType<TankMovement>().RotationSpeed = GameObject.FindObjectOfType<TankMovement>().RotationSpeed * 1.15f;
        GameObject.FindObjectOfType<TankMovement>().speed = GameObject.FindObjectOfType<TankMovement>().speed * 1.15f;
        LevelUpMenu.GetComponent<Canvas>().enabled = !LevelUpMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        Debug.Log(GameObject.FindObjectOfType<TankMovement>().RotationSpeed + "         "+GameObject.FindObjectOfType<TankMovement>().speed);
        Time.timeScale = 1.0f;
    }
    
    public void ImproveFireRateFunction(){
        GameObject.FindObjectOfType<GunRotation>().FireRat_e = GameObject.FindObjectOfType<GunRotation>().FireRat_e / 1.15f;
        LevelUpMenu.GetComponent<Canvas>().enabled = !LevelUpMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        Time.timeScale = 1.0f;
    }
    public void ImproveFHealthFunction(){
        GameObject.FindObjectOfType<TankMovement>().Health = GameObject.FindObjectOfType<TankMovement>().Health + 1.0f;
        LevelUpMenu.GetComponent<Canvas>().enabled = !LevelUpMenu.GetComponent<Canvas>().enabled;
        HUD.GetComponent<Canvas>().enabled = !HUD.GetComponent<Canvas>().enabled;
        Time.timeScale = 1.0f;
    }
}
