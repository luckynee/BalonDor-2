using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modeStar3 : MonoBehaviour
{
    public Animator animator;

    private string currentState;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sulit.bintang == 1 ){
            animator.SetBool("b1",true);
        }
        if(sulit.bintang == 2 ){

            animator.SetBool("b2",true);
        }
        if(sulit.bintang == 3 ){
            animator.SetBool("b3",true);
        }
    }
   
}
