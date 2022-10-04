using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;

    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;

    [SerializeField] private float jump = 10f;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right  * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
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
