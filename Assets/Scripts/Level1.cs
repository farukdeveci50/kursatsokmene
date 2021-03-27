using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    GameObject karakter;
    GameObject text;
    Button ZiplaButon;
    void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Karakter");
        text= GameObject.FindGameObjectWithTag("SkorText");
        ZiplaButon = GameObject.FindGameObjectWithTag("ZiplaButon").GetComponent<Button>();
        ZiplaButon.onClick.AddListener(karakter.GetComponent<Karakter>().Zipla);
        karakter.transform.position = new Vector3(0, 4, 0);
    }

    void Level1BasaGotur()
    {
        if (transform.position.x < -11.35f)
        {
            transform.position = new Vector3(60f, transform.position.y, transform.position.z);
        }
        transform.Translate(Settings.level1SSandıkHiz * Time.deltaTime, 0, 0);
    }
    void FixedUpdate()
    {
        Level1BasaGotur();
        text.GetComponent<Text>().text = karakter.GetComponent<Karakter>().skor.ToString();
        
        if(karakter.GetComponent<Karakter>().skor==100)
        {
            SceneManager.LoadScene(2);
        }

    }
}
