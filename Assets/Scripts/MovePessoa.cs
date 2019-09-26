using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePessoa : MonoBehaviour
{
    public float velTransl;
    float x, z;
    float velRoat;

    // Start is called before the first frame update
    void Start()
    {
        velTransl = 5f;
        this.velRoat = 100f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //TECLAS W OU S
        x = Input.GetAxis("Vertical") * velTransl * Time.deltaTime;
        //TECLAS A OU D
        z = Input.GetAxis("Horizontal") * velTransl * Time.deltaTime;
        transform.Translate(x, z, 0);


        if(Input.GetKey(KeyCode.C)){
            transform.Rotate(0, 0, velRoat);
        }

        if(Input.GetKey(KeyCode.X)){
            transform.Rotate(0, 0, -velRoat);
        }
    }
}
