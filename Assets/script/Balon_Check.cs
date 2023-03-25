using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon_Check : MonoBehaviour
{
    public ControlManager ctrl;
    public setting_menu set;

    void Update()
    {
        if(ctrl.score == 3){
            set.Pause();
        }
    }
}
