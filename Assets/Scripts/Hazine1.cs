using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazine1 : MonoBehaviour
{
    GameObject karakter;
    GameObject text;
    int skor = 0;
    void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Karakter");
        text = GameObject.FindGameObjectWithTag("SkorText");
        skor = karakter.GetComponent<Karakter>().skor;
    }
    //9,5f
    
    void FixedUpdate()
    {
        Hazine1Uret();

    }
    private void OnCollisionEnter2D(Collision2D collision)              
    {
       /* if (collision.gameObject.tag == "OrtaKatmanL1")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z);
        }*/
        if (collision.gameObject.tag == "Karakter")
        {
            if(skor<=100)   //1
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);
            }
            if (skor > 100 && skor <= 200)//2
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);
            }
            if (skor > 200 && skor <= 300)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);
            }
           



        }
    }
    public void Hazine1Uret()
    {
        skor = karakter.transform.GetComponent<Karakter>().skor;
        if (skor <= 100)               //LEVEL 1
        {
            if (transform.position.x <= -11.35f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);
                
            }
            transform.Translate(Settings.level1SSandıkHiz * Time.deltaTime, 0, 0);
        }
        if(skor > 100 && skor <= 200)            //LEVEL 2
        {
            if (transform.position.x <= -9.5f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);

            }
            transform.Translate(Settings.level2SSandıkHiz * Time.deltaTime, 0, 0);
        }
        if (skor > 200 && skor <= 300)            //LEVEL 3
        {
            if (transform.position.x <= -9.5f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(60f, y_degeri, transform.position.z);

            }
            transform.Translate(Settings.level3SSandıkHiz * Time.deltaTime, 0, 0);
        }
       
    }
    
}
