using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;


public class Karakter : MonoBehaviour 
{
    
    Rigidbody2D rb;
    public float ZiplamaGucu;
    public int skor =0;
    

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    public void Zipla()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = Vector2.up * ZiplamaGucu * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mayin")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "ZeminMayin")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "Testere")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "ZeminTestere")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "Mace")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "ZeminMace")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "Hazine1")
        {
            skor += 50;
        }
        if (collision.gameObject.tag == "Hazine2")
        {
            skor += 50;
        }

    }
    void Update()
    {
        DontDestroyOnLoad(this);

        

    }
}
