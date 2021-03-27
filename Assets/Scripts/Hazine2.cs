using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazine2 : MonoBehaviour
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

     
    void FixedUpdate()
    {
        Hazine2Uret();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* if (collision.gameObject.tag == "OrtaKatmanL1")
         {
             transform.position = new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z);
         }*/
        if (collision.gameObject.tag == "Karakter")
        {
            
            if (skor >= 300 && skor <= 400)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(70f, y_degeri, transform.position.z);
            }
            if (skor > 400 && skor <= 500)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(54f, y_degeri, transform.position.z);
            }
            if (skor > 500 && skor <= 600)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(54f, y_degeri, transform.position.z);
            }



        }
    }
    public void Hazine2Uret()
    {
       
        if (skor >= 300 && skor <= 400)      //LEVEL 4
        {
            if (transform.position.x <= -9.5f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(70f, y_degeri, transform.position.z);

            }
            transform.Translate(Settings.level2SSandıkHiz * Time.deltaTime, 0, 0);
        }
        if (skor > 400 && skor <= 500)            //LEVEL 5
        {
            if (transform.position.x <= -9.5f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(54f, y_degeri, transform.position.z);

            }
            transform.Translate(Settings.level3SSandıkHiz * Time.deltaTime, 0, 0);
        }
        if (skor > 500 && skor <= 600)            //LEVEL 6
        {
            if (transform.position.x <= -9.5f)
            {
                float y_degeri = Random.Range(4.8f, -3.5f);
                transform.position = new Vector3(54f, y_degeri, transform.position.z);

            }
            transform.Translate(Settings.level4SSandıkHiz * Time.deltaTime, 0, 0);
        }
    }
}
