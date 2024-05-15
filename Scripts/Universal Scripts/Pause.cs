using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objMenuPause;
    public bool pause_1 =false;
    public GameObject menuSalir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
if (pause_1==false){
    objMenuPause.SetActive(true);
    pause_1=true;
    Time.timeScale = 0;
    Cursor.visible=true;
    Cursor.lockState=CursorLockMode.None;
    AudioSource[] sounds=FindObjectsOfType<AudioSource>();
    for (int i=0;i<sounds.Length; i++){
        sounds[i].Pause();
    }
}
else if (pause_1==true){
    Resume();
}
        }
    }
    public void Resume(){
            objMenuPause.SetActive(false);
            menuSalir.SetActive(false);
pause_1=false;
   Time.timeScale =1;
    Cursor.visible=true;
    Cursor.lockState=CursorLockMode.None;
     AudioSource[] sounds=FindObjectsOfType<AudioSource>();
    for (int i=0;i<sounds.Length; i++){
        sounds[i].Play();
    }
    }
    public void goMenu(string Menu){
SceneManager.LoadScene(Menu);
    }
    public void SALIR()
    {

        Application.Quit();
    }
}
