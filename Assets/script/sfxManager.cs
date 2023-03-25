using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sfxManager : MonoBehaviour
{
    public AudioSource sfx;
    public AudioSource sfx2;


    [SerializeField] 
    Slider sfxSlider;


    // Start is called before the first frame update
    void Start()
    {   
        
        if(!PlayerPrefs.HasKey("sfx"))
        {
            PlayerPrefs.SetFloat("sfx", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolumse()
    {
        sfx.volume = sfxSlider.value;
        sfx2.volume = sfxSlider.value;
        Save();
    }

    private void Load()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfx");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("sfx", sfxSlider.value);
    }
}
