using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public GameObject audioSource;
    public AudioSource bgm;

    void Awake(){
        audioSource = GameObject.FindWithTag("BGM_INGAME");
        bgm = audioSource.GetComponent<AudioSource>();

        bgm.Stop();
    }
}
