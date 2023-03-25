using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI;

public class Destroy2 : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update   

    public GameObject pecahSource;
    public AudioSource pecah;

     public GameObject wrongSource;
    public AudioSource wrong;

    public GameObject target2;
    public ControlManager ctrl;
    public Animator animator;

   void Start()
    {
        pecahSource = GameObject.Find("pecahAudio");
        pecah = pecahSource.GetComponent<AudioSource>();

        wrongSource = GameObject.Find("wrongAudio");
        wrong = wrongSource.GetComponent<AudioSource>();
        
    }
    // Update is called once per frame
    void Update()
    {
      
    }

    public virtual void OnPointerDown (PointerEventData eventData) 
    {
        if(ctrl.iDPeluru == 2){
             animator.SetTrigger("tembak2");
            Destroy(target2,0.3f);
             ctrl.score +=1;
            pecah.Play();
        }else
        {
            wrong.Play();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("end_bar"))
        {
            Destroy(target2, 0.3f);
            ctrl.fail +=3;
            ctrl.failCount +=1;

        }else if(collision.CompareTag("start_bar")){
            ctrl.total +=1;
        }
    }
}
