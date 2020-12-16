using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
    public AudioSource tickSource;

        private void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    //Player cannot move when collided
    public void Update()
    {
         Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"), 0);
         transform.Translate(movementVector * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            tickSource.Play();
        }
    }


}
