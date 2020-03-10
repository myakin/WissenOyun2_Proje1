using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAroundBall : MonoBehaviour
{
    public float rotationSpeed = 1f;
    private float rotationAmount;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotationAmount -= rotationSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotationAmount += rotationSpeed;
        }

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, rotationAmount);
        
        
    }
}
