using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Zaman : MonoBehaviour
{
    public GameObject menu;
    public GameObject win;
    public GameObject devamEt;
    private float sayac;
    private Slider zaman;
    AudioSource audioSource;
    public GameObject oyunmuzik;

    private void Awake()
    {
        zaman=GameObject.Find("Zaman").GetComponent<Slider>();
    }
    private void Start()
    {
        zaman.maxValue = 60;
        zaman.minValue = 0;
        zaman.wholeNumbers= false;
        zaman.value = zaman.maxValue;
        sayac = zaman.value;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;
        }
    }

    public void kazan()
    {
        if (zaman.value==0)
        {
            menu.SetActive(true);
            win.SetActive(true);
            devamEt.SetActive(false);
            Time.timeScale= 0;
            audioSource.Play();
            oyunmuzik.SetActive(false);
        }
        
    }
}
