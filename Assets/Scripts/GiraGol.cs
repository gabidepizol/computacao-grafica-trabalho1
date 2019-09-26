using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraGol : MonoBehaviour
{
    float velRot;

    // Start is called before the first frame update
    void Start()
    {
        this.velRot = 3f;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, velRot);
        
    }
}
