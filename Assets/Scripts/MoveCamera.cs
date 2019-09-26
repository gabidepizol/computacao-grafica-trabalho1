using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float velRot;
    float x, y;
    // Start is called before the first frame update
    void Start()
    {
        velRot = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X") * velRot * Time.deltaTime;
        x = -Input.GetAxis("Mouse Y") * velRot * Time.deltaTime;
        transform.Rotate(x, y, 0);
    }
}
