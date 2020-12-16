using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
<<<<<<< HEAD
    public AudioSource tickSource;
=======
    private bool Move = true;
    public float Delay = 1f;
>>>>>>> 3991a095b93ead453e656420c5002f980c216198

        private void Start()
    {
        tickSource = GetComponent<AudioSource>();
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
    }


    IEnumerator CollisionRoutine()
    {
        Move = false;
        yield return new WaitForSeconds(Delay);
        Move = true;
    }

<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            tickSource.Play();
        }
    }


=======
>>>>>>> 3991a095b93ead453e656420c5002f980c216198
}
