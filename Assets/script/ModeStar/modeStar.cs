using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modeStar : MonoBehaviour
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
        if(mudah.bintang == 1 ){
            animator.SetBool("b1",true);
        }
        if(mudah.bintang == 2 ){

            animator.SetBool("b2",true);
        }
        if(mudah.bintang == 3 ){
            animator.SetBool("b3",true);
        }
    }
   
}
