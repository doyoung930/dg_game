using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private GameObject weapon;
    
    [SerializeField]
    private Transform shootTransform;
    
    [SerializeField]
private float shootInterval = 0.05f;
private float lastShortTime = 0f;

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


        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);
        
        transform.position = new Vector3(toX, -4f, transform.position.z);
    
        Shoot();
    }

    void Shoot(){

        if (Time.time - lastShortTime > shootInterval){
            Instantiate(weapon, shootTransform.position, Quaternion.identity);
            lastShortTime = Time.time;    
        } 
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy"){
            
            Debug.Log("Game Over");
            Destroy(gameObject);
        } else if(other.gameObject.tag == "Coin"){
            Debug.Log ("Coin +1");
            Destroy(other.gameObject);
        }
    }
} 
