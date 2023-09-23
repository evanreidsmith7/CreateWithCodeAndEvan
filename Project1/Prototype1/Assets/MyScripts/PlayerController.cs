using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed = 20.0f;
   public float turnSpeed = 45.0f;
   public float horizontalInput;
   public float verticalInput;

   // Start is called before the first frame update

   void Start()
   {
      // move the vehicle forward 
   }

      // Update is called once per frame
   void LateUpdate() // LateUpdate is called after Update
   {
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");

      transform.Translate(Vector3.forward * Time.deltaTime * speed);

      // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
      // we dont want to move the car left and right, we want to rotate it
      transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
      
   }
}
