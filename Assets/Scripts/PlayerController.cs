using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a temp variable to store 3D positional information
        Vector3 pos = transform.position;
        //get the user input from the keyboard (or whatever Input)
        //and store it in this variable
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        //apply this user input to the space marine
        //so the space marine actually moves
        transform.position = pos;
    }
}
