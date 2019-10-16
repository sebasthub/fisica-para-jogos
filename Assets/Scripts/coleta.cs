using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleta : MonoBehaviour
{
    private int pontos = 0;
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("moeda"))
        {
           
        }
    }
}
