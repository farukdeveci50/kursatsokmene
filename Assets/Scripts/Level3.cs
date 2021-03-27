using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3 : MonoBehaviour
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

    void Level3BasaGotur()
    {
        if (transform.position.x < -20.2f)
        {
            transform.position = new Vector3(50f, transform.position.y, transform.position.z);
        }
        transform.Translate(Settings.level3SSandıkHiz * Time.deltaTime, 0, 0);
    }
    void FixedUpdate()
    {
        Level3BasaGotur();
        text.GetComponent<Text>().text = karakter.GetComponent<Karakter>().skor.ToString();
        if (karakter.GetComponent<Karakter>().skor == 300)
        {
            SceneManager.LoadScene(4);
        }
    }
}
