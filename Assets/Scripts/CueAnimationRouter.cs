using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueAnimationRouter : MonoBehaviour
{
    public CueController cueController;

    public void HitBallOnRouter() {
        cueController.AddForceToTargetBall();
    }

    
}
