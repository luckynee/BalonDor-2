using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public GameObject backgroundMusic;

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");

        if (backgroundMusic != null)
        {
            
            
            // backgroundMusic = this.gameObject;
            // DontDestroyOnLoad(backgroundMusic);
            cekbgmIngame();
            cekbgmIngameganda();
            cekbgmMenuganda();
            cekbgmMenu();
        }
        else
        {
            
        }
    }

    void cekbgmIngame(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Level_Mudah" ||scene.name == "Tutorial"){
        {
        Destroy(GameObject.Find("MenuBGM"));
        }
        }
    }

    void cekbgmMenu(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Main Menu"){
        {
        Destroy(GameObject.Find("IngameBGM"));
        }
        }
    }

    void cekbgmIngameganda(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag("BGM_INGAME");
            if(objs.Length > 1)
                {
                Destroy(this.gameObject);
                }
    }

    void cekbgmMenuganda(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag("BGM");
            if(objs.Length > 1)
                {
                Destroy(this.gameObject);
                }
            else
            {
                DontDestroyOnLoad(this.gameObject);
            }
    }
}
