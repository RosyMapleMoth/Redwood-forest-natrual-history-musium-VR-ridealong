using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour

{
    public int speed = 0;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
    // get input date from keyboard or controller
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    // Update player position based on input
    Vector3 position = transform.position;
    position.x += moveHorizontal * speed * Time.deltaTime;
    position.z += moveVertical * speed * Time.deltaTime;
    transform.position = position;
    }
}