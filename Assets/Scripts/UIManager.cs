using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text forceMagnitudeText;
    public Button hitButton;

    private void Start() {
        hitButton.onClick.AddListener(HitBall);
    }
    
    public void SetForceMagnitude(string aForceMagnitude) {
        forceMagnitudeText.text = aForceMagnitude;
    }

    private void HitBall() {
        GameObject.FindGameObjectWithTag("Player").GetComponent<CueController>().HitBall();
    }

}
