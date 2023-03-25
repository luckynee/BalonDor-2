using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_BoardSedang : MonoBehaviour
{
    public ControlManager ctrl;
    public Animator animator;
    public Text scoreText;
    public Text failText;

    private string currentState;
    private int bintang2 ;

    const string BINTANG0 = "bintang0";
    const string BINTANG1 = "bintang1";
    const string BINTANG2 = "bintang2";
    const string BINTANG3 = "bintang3";


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        hitung();

        scoreText.text = ctrl.score.ToString();
        failText.text = ctrl.failCount.ToString();

        
        if(ctrl.score == ctrl.total){
            ChangeAnimationState(BINTANG3);
           
            sedang.bintang = 3;

        
        }
        else
        if(ctrl.score >= bintang2 ){
            ChangeAnimationState(BINTANG2);
          
            sedang.bintang = 2;

            
        }else
        if(ctrl.score <= bintang2){
            ChangeAnimationState(BINTANG1);
            
            sedang.bintang = 1;

        }
    }
    void ChangeAnimationState(string newState)
    {
        if(currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }

    void hitung(){
        if(ctrl.total % 2 == 0){
            bintang2 = ctrl.total / 2;
        }else{
            bintang2 = (ctrl.total + 1) / 2;
        }
        
    }
}
