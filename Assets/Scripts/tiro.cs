using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public movimento cu;
    private bool lado;
    public GameObject l, r,tir,til;
    void Update()
    {
        cu = GetComponent<movimento>();
        lado = cu.lado;
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (lado == true)
            {
                Instantiate(tir, r.transform.position, Quaternion.identity);
            }
            if (lado == false)
            {
                Instantiate(til, l.transform.position, Quaternion.identity);
            }
        }

    }
}
