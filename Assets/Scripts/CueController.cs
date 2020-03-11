using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueController : MonoBehaviour
{
    public float forceMagnitude;
    public GameObject cue;

    public float rotationSpeed = 1f;
    public Rigidbody targetBallRigidbody;
    public float maxForce = 2000f;

    public Animator cueAnimator;

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

        if (Input.GetKey(KeyCode.W)) {
            forceMagnitude+=10;
            if (forceMagnitude > maxForce) forceMagnitude = maxForce;
            uiManager.SetForceMagnitude(forceMagnitude.ToString());
        } else if (Input.GetKey(KeyCode.S)) {
            forceMagnitude-=10;
            if (forceMagnitude < 0) forceMagnitude = 0;
            uiManager.SetForceMagnitude(forceMagnitude.ToString());
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            transform.position = targetBallRigidbody.transform.position;
        }

        
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!GameObject.FindGameObjectWithTag("SceneLoader").GetComponent<SceneLoader>().mainMenuLoaded) {
                Time.timeScale = 0;
                GameObject.FindGameObjectWithTag("SceneLoader").GetComponent<SceneLoader>().LoadMainMenu();
            }
            
        }
    
    }


    private void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            HitBall();
        }
        if (targetBallRigidbody.IsSleeping()) {
            Camera.main.GetComponent<CameraController>().DisableFollowBall();
        }
    }

    public void HitBall() {
        //Debug.Log((targetBallRigidbody.transform.position - transform.position).magnitude);
        if ((targetBallRigidbody.transform.position - transform.position).magnitude < 0.5f) {
            cueAnimator.SetTrigger("hit");
            //Camera.main.GetComponent<CameraController>().FollowBall();
        }
    }

    public void AddForceToTargetBall() {
        targetBallRigidbody.AddForce(cue.transform.up * forceMagnitude);
    }
}
