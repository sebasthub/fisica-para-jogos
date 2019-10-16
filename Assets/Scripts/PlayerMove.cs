using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Varibles//
    public float PlayerVelocity;
    public float impulse;
    public int jumps;
    public int mony;
    public GameObject coinToDestroy;
    //Varibles//

    void Update()
    {
        Vector3 Moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += Moviment * Time.deltaTime * PlayerVelocity;

        jump();

    }
    //Jump suff start//
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, impulse), ForceMode2D.Impulse);
            jumps--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisions)
    {
        if (collisions.gameObject.CompareTag("Ground"))
        {
            jumps = 2;
        }
    }
    //Jump stuff end//

    //coins start//
    private void OnTriggerEnter2D(Collider2D coincoly)
    {
        if (coincoly.gameObject.CompareTag("Coin"))
        {
            mony++;
            Destroy(coincoly.gameObject);
        }

    }
    //coins end//
}

