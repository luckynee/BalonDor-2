using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool ulang = false;

    public GameObject kalah;

    public ControlManager ctrl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
       if(ctrl.fail >= 10){
        gameOver();
       }
      
    }

    void gameOver(){
            kalah.SetActive(true);
            Time.timeScale = 0f;
    }


}
