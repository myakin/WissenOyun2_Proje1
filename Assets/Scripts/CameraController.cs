using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject camPosRightBackDummyObject, camPosLeftBackDummyObject, camPosRightFrontDummyObject;
    public GameObject camPosLeftFrontDummyObject, camPosTopDummyObject, targetBall, tableCenter;
    public bool followCamera;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            followCamera=false;
            transform.position = camPosRightBackDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            followCamera=false;
            transform.position = camPosLeftBackDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            followCamera=false;
            transform.position = camPosRightFrontDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            followCamera=false;
            transform.position = camPosLeftFrontDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha5)) {
            followCamera=false;
            transform.position = camPosTopDummyObject.transform.position;
            transform.rotation = camPosTopDummyObject.transform.rotation;

        } else if (Input.GetKeyDown(KeyCode.Alpha6)) {
            CameraNearBall();
        }

        if (followCamera) {
            CameraNearBall();
        }

    }

    private void CameraNearBall() {
        transform.position = targetBall.transform.position + (-tableCenter.transform.forward * 3f) + (tableCenter.transform.up * 2f);
        transform.LookAt(targetBall.transform);
    }

    public void FollowBall() {
        followCamera = true;
    }
    public void DisableFollowBall() {
        followCamera = false;
        transform.position = camPosTopDummyObject.transform.position;
        transform.rotation = camPosTopDummyObject.transform.rotation;
    }

}
