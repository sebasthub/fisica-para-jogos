using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public int velo = 5;
    private float controle, forca = 250f;
    public int duplo = 2;
    public Rigidbody2D puto;
    void Update()
    {
        controle = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(controle * velo * Time.deltaTime, 0));
        if (Input.GetKeyDown(KeyCode.Space)) 
            {
            pulo();
            }
    }
    public void pulo() {
        if (duplo > 0)
        {
            
            puto.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
            duplo--;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            duplo = 2;
        }
    }
}
