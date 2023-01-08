using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public float hiz;
    public float hiz2;
    void Start()
    {
        
    }

    void Update()
    {
        enemy1.transform.Translate(hiz * Time.deltaTime, 0, 0);
        if (enemy1.transform.position.x>=15)
        {
            float yer = Random.Range(-9f, -5f);
            enemy1.transform.position = new Vector3(yer, 0.67f, -3f);
        }
        enemy2.transform.Translate(-hiz2 * Time.deltaTime, 0, 0);
        if (enemy2.transform.position.x <= -7)
        {
            float yer2 = Random.Range(15f, 20f);
            enemy2.transform.position = new Vector3(14.11f, 0.67f, -3f);
        }
    }
}
