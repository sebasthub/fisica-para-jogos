using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public int velo = 5;
    private float controle;
    void Update()
    {
        controle = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(controle * velo * Time.deltaTime, 0));
    }
}
