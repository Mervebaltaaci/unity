using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terim : MonoBehaviour
{
    public GameObject hayvanlarani;
    public GameObject veripaneli;
    
    public void yarismabaslat()
    {

        
        
       StartCoroutine(panelac());

    }
    public void yedirmeyibaslat()
    {
        hayvanlarani.GetComponent<Animator>().enabled = true;
    }
    IEnumerator panelac()
    {
        yield return new WaitForSeconds(1);
        veripaneli.SetActive(true);
    }
    public void yedirt()
    {
        StartCoroutine(yedirhayvanlarr());
        
    }
    public GameObject hayvanlarr;
    

    int derece1 = 0;
    int derece2 = 0;

    int yemesayisi = 0;
    IEnumerator yedirhayvanlarr()
    {
        yemesayisi++;
        if (yemesayisi%2==1)
        {
            derece1 = 1;
        }
        yield return new WaitForSeconds(Time.deltaTime);
        float sure = 0.2f;
        Vector3 startpos = hayvanlarr.transform.position;

        

       Vector3 endpos = startpos + new Vector3(-1, 0, 0);

       


        while (sure>0)
        {
            sure -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
            hayvanlarr.transform.position= Vector3.Lerp(endpos, startpos, sure / 0.2f);
            


        }
        hayvanlarr.transform.GetChild(0).gameObject.SetActive(true);
        
        Text degerkutusu = hayvanlarr.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>();
        

        sure = Random.Range(1, 10);
        float maxvalue = sure;
        while (sure > 0)
        {
            sure -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
            Debug.Log("Süre:" + (maxvalue - sure).ToString());
            degerkutusu.text = (maxvalue - sure).ToString("F0");
            


        }
        yemesayisi++;
        if (yemesayisi % 2 == 1)
        {
            derece1 = Mathf.RoundToInt (maxvalue);
        }
        else

        {
            derece2 = Mathf.RoundToInt(maxvalue);
        }


        sure = 0.8f;
        while (sure > 0)
        {
            sure -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
            hayvanlarr.transform.position = Vector3.Lerp(startpos, endpos, sure / 0.8f);
            


        }


    }
    public InputField olcum1;
    public InputField olcum2;
    public InputField sonucust;
    public InputField sonucalt;

    public void kontrolet()
    {
        if (olcum1.text == derece1.ToString() && olcum2.text == derece2.ToString() && sonucust.text == (derece1 + derece2).ToString())
        {
            Debug.Log("BAŞARILI");

        }

        else

        {
            Debug.Log("HATALI");
        }
    }
}
