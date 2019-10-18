using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coleta : MonoBehaviour
{
    public int pontos = 0;
    public GameObject g;
    private Text omg;
    private AudioSource audio;
    private void Start()
    {
        omg = g.GetComponent<Text>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        omg.text = "pontos: " + pontos;
    }
    private void OnCollisionEnter2D(Collision2D outro)
    {        
        if (outro.gameObject.CompareTag("moeda"))
        {
            Destroy(outro.gameObject);
            pontos++;
            audio.PlayOneShot(audio.clip);
        }
    }
}
