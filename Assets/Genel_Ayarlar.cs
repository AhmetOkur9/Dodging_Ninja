using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Genel_Ayarlar : MonoBehaviour
{
    public GameObject menu;
    public GameObject devamEt;

    public void durdur_btn()
    {
        menu.SetActive(true);
        Time.timeScale = 0.0f;
        devamEt.SetActive(true);
    }

    public void devam_et()
    {
        menu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void yeniden_baslat()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1.0f;
    }
    public void oyundan_cik()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            menu.SetActive(true);
            Time.timeScale = 0.0f;
            devamEt.SetActive(true);
        }
    }

}
