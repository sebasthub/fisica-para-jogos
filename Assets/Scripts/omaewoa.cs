using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omaewoa : MonoBehaviour
{
    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("inimigo"))
        {
            Destroy(outro.gameObject);
        }
    }
}
