using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void SceneLoad(string SceneName)
    {
        
        SceneManager.LoadScene(SceneName);
       
    }
   
    public void ExitClicked()
    {
        Application.Quit();
    }

}
