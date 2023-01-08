using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class Karakter : MonoBehaviour
{
    private Rigidbody rb;
    public float zipla;
    public float hiz;
    public Animator anim;
    bool isJump;
    public Image Can1;
    public Image Can2;
    public Image Can3;
    private int carpti;
    public GameObject menu;
    public GameObject devam_et;
    public GameObject win;
    AudioSource audioSource;
    public GameObject oyunmuzik;
    

    void Start()
    {
        rb =GetComponent<Rigidbody>();
        audioSource= GetComponent<AudioSource>();
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, -1);
            anim.SetTrigger("run");
            transform.Translate(0, 0, -hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            anim.SetTrigger("run");
            transform.Translate(0, 0, hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isJump==false)
            {
                rb.AddForce(Vector2.up * zipla);
                anim.SetTrigger("jump");
                isJump = true;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow)==false)
        {
            anim.SetTrigger("idle");
        }

        float xPosition = Mathf.Clamp(transform.position.x, -0.58f, 10.46f);
        transform.position=new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            carpti = carpti + 1;
            if (carpti==1)
            {
                Can1.color = Color.black;
            }
            if (carpti == 2)
            {
                Can2.color = Color.black;
            }
            if (carpti == 3)
            {
                Can3.color = Color.black;
            }
        }
        if (carpti==3)
        {
            Time.timeScale = 0.0f;
            menu.SetActive(true);
            win.SetActive(false);
            devam_et.SetActive(false);
            audioSource.Play();
            oyunmuzik.SetActive(false);
            
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = false;
        }
    }
}
