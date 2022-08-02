using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragg : MonoBehaviour
{
    Vector3 startpos;
    public bool isinside = false;
    public string hedeftag = "semboller";
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
        this.transform.position = startpos;   
    }
}
