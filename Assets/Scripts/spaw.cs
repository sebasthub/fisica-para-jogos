using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject buraco, negro;
    private coleta c;
    private float net =0;
    void Update()
    {
        c = negro.GetComponent<coleta>();
        if (c.pontos == 2) 
        {
            if (net == 0)
            {
                Instantiate(buraco, transform.position, Quaternion.identity);
                net = net + 1;
            }
        }
    }
}
