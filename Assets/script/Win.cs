using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public ControlManager ctrl;

    public GameObject win;
    public GameObject wingambar;
    public GameObject score;

    private int cek;
    public bool clear1;
    public bool clear2;
    public bool clear3;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        cek = ctrl.score + ctrl.failCount;

        if(ctrl.total != 0){
            if(cek == ctrl.total){
            StartCoroutine(next());
            menang();
            }
        }
    }
        

    void menang(){
            clear1 = true;
            clear2 = true;
            clear3 = true;
            win.SetActive(true);
            
    }
    IEnumerator next(){
        yield return new WaitForSeconds(2);
        Debug.Log("next");
        wingambar.SetActive(false);
        score.SetActive(true);

    
    }
}
