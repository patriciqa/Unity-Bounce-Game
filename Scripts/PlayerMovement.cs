using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;


    //Player cannot move when collided
   public void Update()
    {
         Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"), 0);
         transform.Translate(movementVector * Time.deltaTime * Speed);
    }

   
}
