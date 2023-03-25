using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class ControlManager : MonoBehaviour 
{
    public merahDrag merah;
    public kuningDrag kuning;
    public biruDrag biru;
    private int tempPeluru;
    public Win win;
    


    
    [HideInInspector] 
    public int iDPeluru;
    public bool desMerah , desBiru , desKuning;
    public int score;
    public int fail;
    public int failCount;
    public int total;

    // Start is called before the first frame update
    void Start()
    {
        win.clear1 = false;
        mudah.bintang = 0;
        sedang.bintang = 0;
        sulit.bintang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        iDPeluru = tempPeluru;
       
        Merah();
        Kuning();
        Biru();

        Debug.Log(""+iDPeluru);
        Debug.Log("score"+score);
        Debug.Log("fail"+fail);
        Debug.Log("fail"+failCount);
        Debug.Log("total"+total);

    }

    void Merah(){
        if(merah.inColMerah == true){
            tempPeluru = 1;
        
        }else
        if(merah.inColBiru == true){
            tempPeluru = 4;
           
        }else
        if(merah.inColKuning == true){
            tempPeluru = 5;
      
        }
    }

    void Kuning(){
        if(kuning.inColKuning == true){
            tempPeluru = 2;
        }else
        if(kuning.inColBiru == true){
            tempPeluru = 6;
        }else
        if(kuning.inColMerah == true){
            tempPeluru = 5;
        }
    }

    void Biru(){
        if(biru.inColBiru == true){
            tempPeluru = 3;
        }else
        if(biru.inColKuning == true){
            tempPeluru = 6;
        }else
        if(biru.inColMerah == true){
            tempPeluru = 4;
        } 
    }

}
