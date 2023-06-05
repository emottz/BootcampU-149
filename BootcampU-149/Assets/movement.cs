using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{

    RaycastHit carpma;

    public GameObject cursor_;

    

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

        Ray isin = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(isin, out carpma))
        {

            cursor_.transform.LookAt(carpma.point);

        }


    }

    void MousePos()
    {
       
        

    }

}
