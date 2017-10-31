using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControls : MonoBehaviour {

    public Slider slider;
    public Slider masterVol;
    public AudioSource audioSource;
    
    public void Start()
    {
        if (masterVol.isActiveAndEnabled)
        {
            masterVol.onValueChanged.AddListener(SetMasterVol);
        }
    }

    public void ChangeVol()
    {
        audioSource.volume = slider.value;
    }

    public void SetMasterVol(float masterVol)
    {
        AudioListener.volume = masterVol;
    }
}
