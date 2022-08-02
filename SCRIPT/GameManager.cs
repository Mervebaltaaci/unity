using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
  
    public GameObject[] sayılar;
    public GameObject feedbackpanel;
    public GameObject feedbackpanel1;


    void Start()
    {
        sayılar = GameObject.FindGameObjectsWithTag("sayılar");
        feedbackpanel.SetActive(false);
        feedbackpanel1.SetActive(false);

    }
    public void kontrolet()
    {
        Debug.Log("Kontrol Fonksiyonu Çalıştı");
        Debug.Log("Eşleşme Değerleri 1: " + sayılar[0].GetComponent<DRAG>().iscorrectmatch);

        int dogrusayisi = 0;
        int yanlissayisi = 0;

        foreach (GameObject sayıobjesi in sayılar)
        {
            Debug.Log("Eşleşme Değerleri 1 foreach: " + sayıobjesi.GetComponent<DRAG>().iscorrectmatch);
            if (sayıobjesi.GetComponent<DRAG>().iscorrectmatch)
            {
                dogrusayisi++;
            }
            else
            {
                if (sayıobjesi.GetComponent<DRAG>().isinside)
                {
                    yanlissayisi++;
                    sayıobjesi.GetComponent<DRAG>().basadon();
                }
            }
        }
        string mesaj = "";
        bool hepsidogru = false;
        if (dogrusayisi == sayılar.Length)
        {
            mesaj = "Tebrikler Tümünü Doğru Yaptın!";
            hepsidogru = true;
        }
        else
        {
            hepsidogru = false;
            mesaj = dogrusayisi + " adet doğru " + yanlissayisi + " adet yanlış eşleştirdin.";
        }
        mesajgoster(mesaj, hepsidogru);

    }
    void mesajgoster(string icerik, bool sonra)
    {
        if (sonra)
        {
            feedbackpanel.transform.GetChild(1).gameObject.SetActive(false);
            feedbackpanel.transform.GetChild(2).gameObject.SetActive(true);

        }
        else
        {
            feedbackpanel.transform.GetChild(1).gameObject.SetActive(true);
            feedbackpanel.transform.GetChild(2).gameObject.SetActive(false);

        }
        feedbackpanel.transform.GetChild(0).GetComponent<Text>().text = icerik;
        feedbackpanel.SetActive(true);
    }

    public void sonraki(int sceneno)
    {
        SceneManager.LoadScene(sceneno);
    }

  
 }
