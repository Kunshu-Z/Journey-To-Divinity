using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System.Security.Authentication.ExtendedProtection;
using System.Globalization;
using UnityEngine.SceneManagement;

public class Meter : MonoBehaviour
{
    public GameObject CrimsonBar;
    public Slider CrimsonSlider;
    public int MaxCrimson = 100;
    public int CurrentCrimson;
    public bool CrimsonFull; 

    // Start is called before the first frame update
    void Start()
    {
        CrimsonSlider.interactable = false;
        CurrentCrimson = MaxCrimson;
        UpdateCrimson();
    }

    public void UpdateCrimson()
    {
        float crimsonValue = (float)CurrentCrimson / MaxCrimson;
        CrimsonSlider.value = crimsonValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
