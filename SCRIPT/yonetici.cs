using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class yonetici : MonoBehaviour

{
    int yerpar = 0;
    int toppuz = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void art ()
    {
        yerpar++;
        if(yerpar == toppuz)
        {
            SceneManager.LoadScene(16);
        }
        
    }
}
