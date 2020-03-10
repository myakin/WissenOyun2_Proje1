using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rot;
    [SerializeField] private float rotSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rot += rotSpeed;
        transform.rotation = Quaternion.Euler(new Vector3 (0, rot, 0));
    }
}
