using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urutan_Tutor : MonoBehaviour
{
    public ControlManager ctrl;
    public GameObject kuning;
    public GameObject biru;
    public GameObject tutor1;
    public GameObject tutor2;
    public GameObject tutor3;
    public GameObject tutor4;
    public GameObject tutor5;
    public GameObject tutor6;
    public GameObject tutor7;
    public GameObject tutor8;
    public GameObject balon;



    public GameObject primer;
    public GameObject sekunder;

    public GameObject win;
    public GameObject wingambar;
    public GameObject score;

    private int cek;
    
    private bool tahap1;
    private bool tahap2;
    private bool tahap3;
    private bool tahap4;
    private bool tahap5;
    private bool tahap6;
    private bool tahap7;
    private bool tahap8;


    private int wave1;
    private int wave2;
    private int wave4;



    // Start is called before the first frame update
    void Start()
    {
        tahap1 = true;
        wave1 = 4;
        wave2 = 7;
        wave4 = 19;
            ctrl.total = wave4;
    }

    // Update is called once per frame
    void Update()
    {
        gantitahap();

        if(tahap1 == true){
            tutor1.SetActive(true);
            kuning.SetActive(false);
            biru.SetActive(false);
        }else if(tahap2 == true){
            tutor1.SetActive(false);
            tutor2.SetActive(true);
            kuning.SetActive(true);
            biru.SetActive(true);
        }

        if(ctrl.score == wave1){
            tutor4.SetActive(true);
            tutor3.SetActive(false);
        }else
        if(ctrl.score == wave2){
            tutor5.SetActive(true);
            tutor4.SetActive(false);
        }

        if(tutor6.activeSelf == true){
            tutor5.SetActive(false);
        }
         if(tutor7.activeSelf == true){
            tutor5.SetActive(false);
        }
         if(tutor8.activeSelf == true){
            tutor5.SetActive(false);
        }
        if(balon.activeSelf == true){
            tutor5.SetActive(false);
        }
         if(win.activeSelf == true){
            tutor5.SetActive(false);
        }
           
       
        if(wave4 == ctrl.score){
         menang();
        }
        
    }

    

    void gantitahap(){
        if(ctrl.iDPeluru == 1 || ctrl.iDPeluru == 2 || ctrl.iDPeluru == 3 || ctrl.iDPeluru == 4 || ctrl.iDPeluru == 5 || ctrl.iDPeluru == 6 ){
            if(tutor1.activeSelf == true){
                tahap1 = false;
                tahap2 = true;
                
            }
        }
    }

    public void totutor3(){
        tutor2.SetActive(false);
        tutor3.SetActive(true);
        tahap2 = false;
    }

    public void primernext(){
        primer.SetActive(false);
        tutor5.SetActive(true);
    }
    

    void menang(){
            win.SetActive(true);
            StartCoroutine(next());
            
    }

    public void totutor6(){
        if( ctrl.iDPeluru == 4 || ctrl.iDPeluru == 5 || ctrl.iDPeluru == 6){
            tutor6.SetActive(true);
            tutor5.SetActive(false);
        }
    }

    public void totutor7(){
        tutor6.SetActive(false);
        tutor7.SetActive(true);
    }

    public void totutor8(){
        tutor7.SetActive(false);
        tutor8.SetActive(true);
    }

    public void tutup(){
        tutor8.SetActive(false);
        balon.SetActive(true);
    }
    
    IEnumerator next(){
        yield return new WaitForSeconds(2);
        Debug.Log("next");
        wingambar.SetActive(false);
        score.SetActive(true);

    
    }
    
}
