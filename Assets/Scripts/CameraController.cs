using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject camPosRightBackDummyObject, camPosLeftBackDummyObject, camPosRightFrontDummyObject;
    public GameObject camPosLeftFrontDummyObject, camPosTopDummyObject, targetBall, tableCenter;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            transform.position = camPosRightBackDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            transform.position = camPosLeftBackDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            transform.position = camPosRightFrontDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            transform.position = camPosLeftFrontDummyObject.transform.position;
            transform.LookAt(tableCenter.transform);

        } else if (Input.GetKeyDown(KeyCode.Alpha5)) {
            transform.position = camPosTopDummyObject.transform.position;
            transform.rotation = camPosTopDummyObject.transform.rotation;

        } else if (Input.GetKeyDown(KeyCode.Alpha6)) {
            transform.position = targetBall.transform.position + (-tableCenter.transform.forward * 3f);
            transform.LookAt(targetBall.transform);

        }
    }

}
