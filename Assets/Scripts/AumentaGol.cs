using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaGol : MonoBehaviour
{
   bool big;

    // Start is called before the first frame update
    void Start()
    {
        big = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (!big) {
         aumentar();
        } else
        {
            diminuir();
        }
    }

    void aumentar()
    {
        if (transform.localScale.y < 1) { 
            transform.localScale += new Vector3(0, 0.02f, 0);
        } else
        {
            big = !big;
        }
    }

    void diminuir(){
        if (transform.localScale.y > 0)
        {
            transform.localScale += new Vector3(0, -0.02f, 0);
        }
        else
        {
            big = !big;
        }
}
}
