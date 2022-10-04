using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.TextCore.Text;
using Vector3 = UnityEngine.Vector3;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    
    /*[Header("CharacterController")]
    [SerializeField] private CharacterController controller;*/

    [Header("Balancing")]
    [SerializeField] private float jump = 10f;
    
    [Header("Controls")]
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;
    [SerializeField] private float speed = 2f;
    
    [SerializeField] private Rigidbody characterBody;

    private void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.
*/
        //controller.Move(move * Time.deltaTime * speed);

        
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            //input getaxis will make everything go to the left as well. 
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space) && characterBody.velocity.y <= 0.05f) //velocity prevents player from jumping twice
        {
            Jump();
        }
        
        /*if (Input.GetAxis("Horizontal") != 0)
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
            
            //Space.World
            currentPlayer.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        }*/
        
        /*if (Input.GetAxis("Horizontal") != 0)
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
            
            //Space.World
            currentPlayer.transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }*/
    }
    
    private void Jump()
    {
        //characterBody.velocity = Vector3.up * jump;
        characterBody.AddForce(Vector3.up * jump);
    }
}
