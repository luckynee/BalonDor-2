using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisbaleButtonSulit : MonoBehaviour
{
    public Button button;
    public modeStar2 modeStar; 

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(modeStar.animator.GetBool("b1") == true || modeStar.animator.GetBool("b2") == true || modeStar.animator.GetBool("b3") == true){
            button.interactable = true;
        }else
        {
            button.interactable = false;
        }
    }
}
