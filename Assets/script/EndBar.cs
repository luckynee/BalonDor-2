using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBar : MonoBehaviour
{
    public ControlManager ctrl;
    public Animator animator;

    private string currentState;

    const string END_BAR0 = "end_bar0";
    const string END_BAR1 = "end_bar1";
    const string END_BAR2 = "end_bar2";
    const string END_BAR3 = "end_bar3";
    const string END_BAR4 = "end_bar4";
    const string END_BAR5 = "end_bar5";
    const string END_BAR6 = "end_bar6";
    const string END_BAR7 = "end_bar7";
    const string END_BAR8 = "end_bar8";
    const string END_BAR9 = "end_bar9";
    const string END_BAR10 = "end_bar10";


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(failCount());
    }

    // Update is called once per frame
    void Update()
    {
        if(ctrl.fail == 0){
            ChangeAnimationState(END_BAR0);
        }
        else if(ctrl.fail == 1)
        {
        ChangeAnimationState(END_BAR1);
        }else if(ctrl.fail == 2)
        {
        ChangeAnimationState(END_BAR2);
        }else if(ctrl.fail == 3)
        {
        ChangeAnimationState(END_BAR3);
        }else if(ctrl.fail == 4)
        {
        ChangeAnimationState(END_BAR4);
        }else if(ctrl.fail == 5)
        {
        ChangeAnimationState(END_BAR5);
        }else if(ctrl.fail == 6)
        {
        ChangeAnimationState(END_BAR6);
        }else if(ctrl.fail == 7)
        {
        ChangeAnimationState(END_BAR7);
        }else if(ctrl.fail == 8)
        {
        ChangeAnimationState(END_BAR8);
        }else if(ctrl.fail == 9)
        {
        ChangeAnimationState(END_BAR9);
        }else if(ctrl.fail == 10){
        ChangeAnimationState(END_BAR10);
        }else if(ctrl.fail > 10){
        ChangeAnimationState(END_BAR10);
       }
    }

    void ChangeAnimationState(string newState)
    {
        if(currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
    
    IEnumerator failCount(){
        while(true){
            yield return new WaitForSeconds(2);
            if(ctrl.fail > 0){
                 ctrl.fail -=1;
            }
           
            Debug.Log("fail berkurang");
            
        }
    }
    
}
