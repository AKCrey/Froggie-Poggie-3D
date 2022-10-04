using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] private float speed = 2f;
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right  * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            //input getaxis will make everything go to the left as well. 
        }
    }
}
