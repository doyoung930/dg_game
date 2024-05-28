using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");

        // Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);

        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime,0,0);
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= moveTo;

        }else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += moveTo;
        }
    }
}
