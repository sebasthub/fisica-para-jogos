using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiromuv : MonoBehaviour
{
    public int velocimetro = 5;
    void Update()
    {
        transform.Translate(new Vector2(10 *velocimetro * Time.deltaTime, 0));
    }
}
