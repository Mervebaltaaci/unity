using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRAG : MonoBehaviour
{
    Vector3 startpos;
    public bool isinside = false;
    public string hedeftag = "semboller" ;
    public bool iscorrectmatch = false;

    // Start is called before the first frame update
    void Start()
    {
        startpos = this.transform.position;
    }
    void OnMouseDrag()

    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
    }
    void OnMouseUp()
    {
        if (!isinside) 
        {
            basadon();
            calistir.makinevar = false;
        }
        else
        {
            calistir.makinevar = true;
        }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("içeri girdi");
        isinside = true;
       if (col.gameObject.tag==hedeftag)
        {
           iscorrectmatch = true;
            
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        iscorrectmatch = false;
        Debug.Log("içerden Çıktı");
        isinside = false;

    }
    public void basadon()
    {
        this.transform.position = startpos;
    }
}
