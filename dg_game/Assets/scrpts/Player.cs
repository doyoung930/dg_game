using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting.FullSerializer;
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

    //---
        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime,0,0);
        // if(Input.GetKey(KeyCode.LeftArrow)){
        //     transform.position -= moveTo;

        // }else if(Input.GetKey(KeyCode.RightArrow)){
        //     transform.position += moveTo;
        // }

    //---


        UnityEngine.Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);
        
        transform.position = new UnityEngine.Vector3(toX, -4f, transform.position.z);
    }
} 
