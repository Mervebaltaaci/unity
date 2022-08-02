using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class calistir : MonoBehaviour
{
    public static bool makinevar = false;
    public GameObject makine;
    public GameObject sise;
    public Dropdown litresayisi;
    public GameObject[] litreler;

    void start()
    { 
        doldur();
    }
    public void Calistir()
    {
        StartCoroutine(surelicalistir());
    }
        IEnumerator surelicalistir()
        {
        
        foreach (GameObject g in litreler)
            {
                g.SetActive(false);
            }

            if (makinevar)
            {
                sise.GetComponent<Animator>().enabled = true;
                sise.GetComponent<Animator>().Play("sise2");
            makine.GetComponent<Animator>().enabled = true;
            yield return new WaitForSeconds(1.95f);
            makine.GetComponent<Animator>().enabled = false;
            sise.GetComponent<Animator>().enabled = false;

                switch (litresayisi.options[litresayisi.value].text)
                {
                    case "1":
                        litreler[0].SetActive(true);
                        break;
                    case "2":
                        litreler[1].SetActive(true);
                        break;
                    case "3":
                        litreler[2].SetActive(true);
                        litreler[0].SetActive(true);
                    break;
                    case "4":
                        litreler[3].SetActive(true);
                    break;
                    case "5":
                        litreler[4].SetActive(true);
                    litreler[0].SetActive(true);
                    break;
                    case "6":
                        litreler[5].SetActive(true);
                    litreler[1].SetActive(true);
                    break;
                    case "7":
                        litreler[6].SetActive(true);
                    litreler[0].SetActive(true);
                    litreler[1].SetActive(true);
                    break;
                }

            }
            else
            {
                Debug.Log("Makineye şişe yerleştirmedin.");
            }
        }
    

        public static int birinci = 0;
        public static int ikinci = 0;
        public static int ucuncu = 0;
    public static int dorduncu = 0;
    public Dropdown ddl1;
        public Dropdown ddl2;
        public Dropdown ddl3;
    public Dropdown ddl4;
    public void kaydet()
        {
            birinci = ddl1.value;
        ikinci = ddl2.value;
        ucuncu = ddl3.value;
        dorduncu = ddl4.value;
        }
        public void doldur()
        {
        ddl1.value = birinci;
        ddl2.value = ikinci;
        ddl3.value = ucuncu;
        ddl4.value = dorduncu;
        }
        public void sonraki()
        {
            SceneManager.LoadScene(31);
        }
}