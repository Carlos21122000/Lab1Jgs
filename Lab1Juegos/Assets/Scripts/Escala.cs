using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            double x = 0.02;
            double y = 0.02;
            double z = 0.02;

            transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }
        else if(Input.GetKey(KeyCode.Z))
        {
            transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }
        //transform.localScale += Vector3.one * 1 * Time.deltaTime;

       // transform.localScale += (new Vector3(Input.GetAxis("Submit") * 2, 0,
        //    Input.GetAxis("Submit") * 2) * Time.deltaTime);

       // transform.localScale -= (new Vector3(Input.GetAxis("Jump") * 2, 0,
          //  Input.GetAxis("Jump") * 2) * Time.deltaTime);
    }
}
