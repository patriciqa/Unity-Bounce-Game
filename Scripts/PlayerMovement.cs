using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
    public AudioSource tickSource;
    private bool Move = true;
    public float Delay = 1f;

    private void Start()
    {
        tickSource = GetComponent<AudioSource>();
        StartCoroutine(StartDelay());
    }

    //Player cannot move when collided
    public void Update()
    {
        if(Move == true)
        {
            Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"), 0);
            transform.Translate(movementVector * Time.deltaTime * Speed);
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(CollisionRoutine());
        if(collision.gameObject.tag == "Obstacle")
        {
            tickSource.Play();
        }
    }

    IEnumerator StartDelay()
    {
        Move = false;
        yield return new WaitForSeconds(3);
        Move = true;
    }

    IEnumerator CollisionRoutine()
    {
        Move = false;
        yield return new WaitForSeconds(Delay);
        Move = true;
    }
}
