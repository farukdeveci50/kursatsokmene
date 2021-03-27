using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarketKosu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void BasaGotur()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            if (transform.position.x >= 9f)
            {
                transform.position = new Vector3(-9f, transform.position.y, transform.position.z);
            }
            transform.Translate(3f * Time.deltaTime, 0, 0);
        }
        else
        {

        } 
    }   
    void FixedUpdate()
    {
        BasaGotur();
    }
}
