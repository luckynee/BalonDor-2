using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public GameObject audioSource;
    public AudioSource bgm;

    [SerializeField] 
    Slider bgmSlider;


    // Start is called before the first frame update
    void Start()
    {   
        if(audioSource == null){
            audioSource = GameObject.FindWithTag("BGM");
            bgm = audioSource.GetComponent<AudioSource>();
        }
    

        if(!PlayerPrefs.HasKey("bgm"))
        {
            PlayerPrefs.SetFloat("bgm", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolumse()
    {
        bgm.volume = bgmSlider.value;
        Save();
    }

    private void Load()
    {
        bgmSlider.value = PlayerPrefs.GetFloat("bgm");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("bgm", bgmSlider.value);
    }
}
