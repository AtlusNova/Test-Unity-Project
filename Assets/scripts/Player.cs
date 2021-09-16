using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.3f;






    // Update is called once per frame
    void Update()
    {
        //stores the temporary possition of the game object
        Vector3 temp = this.transform.position;
        

        //adds the float speed to the temp value
        temp.x += speed;


        //assigns the value of temp to the objects actual position
        this.transform.position = temp;
    }
}
