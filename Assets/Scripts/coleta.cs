using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coleta : MonoBehaviour
{
    public int pontos = 0;
    public GameObject g;
    private Text omg;
    private AudioSource audio;
    public int tempo = 0;
    private void Start()
    {
        omg = g.GetComponent<Text>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        omg.text = "pontos: " + pontos;
        if (pontos == 2) 
        {

            if (tempo >= 100)
            {
                SceneManager.LoadScene("Cena3");
            }
        }
    }
    private void FixedUpdate()
    {
        if (pontos == 2)
        {
            tempo += 1;
        }
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
