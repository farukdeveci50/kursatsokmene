using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level6 : MonoBehaviour
{
    GameObject karakter;
    GameObject text;
    Button ZiplaButon;
    void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Karakter");
        text = GameObject.FindGameObjectWithTag("SkorText");
        karakter.transform.position = new Vector3(0, 4, 0);
        ZiplaButon = GameObject.FindGameObjectWithTag("ZiplaButon").GetComponent<Button>();
        ZiplaButon.onClick.AddListener(karakter.GetComponent<Karakter>().Zipla);
    }

    void Level6BasaGotur()
    {
        if (transform.position.x < -20.2f)
        {
            transform.position = new Vector3(43f, transform.position.y, transform.position.z);
        }
        transform.Translate(Settings.level4SSandıkHiz * Time.deltaTime, 0, 0);
    }
    void FixedUpdate()
    {
        Level6BasaGotur();
        text.GetComponent<Text>().text = karakter.GetComponent<Karakter>().skor.ToString();
        if (karakter.GetComponent<Karakter>().skor == 600)
        {
            SceneManager.LoadScene(0);
        }
    }
}
