using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueController : MonoBehaviour
{
    public float forceMagnitude;
    public GameObject cue;

    public float rotationSpeed = 1f;
    public Rigidbody targetBallRigidbody;

    private UIManager uiManager;

    private void Start() {
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        uiManager.SetForceMagnitude(forceMagnitude.ToString());
    }
    
    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            transform.rotation *= Quaternion.Euler(0,rotationSpeed,0);

        } else if (Input.GetKey(KeyCode.D)) {
            transform.rotation *= Quaternion.Euler(0,-rotationSpeed,0);
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            forceMagnitude+=50;
            uiManager.SetForceMagnitude(forceMagnitude.ToString());
        } else if (Input.GetKeyDown(KeyCode.S)) {
            forceMagnitude-=50;
            uiManager.SetForceMagnitude(forceMagnitude.ToString());
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            transform.position = targetBallRigidbody.transform.position;
        }
    }


    private void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            HitBall();
        }
    }

    public void HitBall() {
        //Debug.Log((targetBallRigidbody.transform.position - transform.position).magnitude);
        if ((targetBallRigidbody.transform.position - transform.position).magnitude < 0.5f)
            targetBallRigidbody.AddForce(cue.transform.up * forceMagnitude);
    }
}
