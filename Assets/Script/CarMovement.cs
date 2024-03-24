using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public int forw = 40;
    public int izq = 5;
    public int dere = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forw);
        if (Input.GetKey(KeyCode.Q)) //izq
        {
            //transform.Translate(Vector3.left * Time.deltaTime * izq);
            transform.Rotate(0,-1,0);
        }
        if (Input.GetKey(KeyCode.E)) //dere
        {
            //transform.Translate(Vector3.right * Time.deltaTime * dere);
            transform.Rotate(0,1,0);
        }
    }
}
