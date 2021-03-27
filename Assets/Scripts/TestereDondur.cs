using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestereDondur : MonoBehaviour
{
    GameObject zemintestere;
    public float angle;
    void Start()
    {
        zemintestere = GameObject.FindGameObjectWithTag("ZeminTestere");
    }


    void FixedUpdate()
    {
        for (int i = 0; i <= 25; i++)
        {
            zemintestere.transform.GetChild(i).gameObject.transform.Rotate(Vector3.forward, -angle * Time.deltaTime);
        }
    }
}
