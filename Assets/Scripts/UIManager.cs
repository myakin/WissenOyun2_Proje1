using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text forceMagnitudeText;
    public Button hitButton;

    public Image progressbarImage;
    


    private void Start() {
        hitButton.onClick.AddListener(HitBall);
        SetProgresbar();

    }

    public void SetProgresbar() {
        CueController cueController = GameObject.FindGameObjectWithTag("Player").GetComponent<CueController>();
        float currentForceMagnitude = cueController.forceMagnitude;
        float rate = currentForceMagnitude / cueController.maxForce;

        float progressbarContainerHeight = progressbarImage.transform.parent.GetComponent<RectTransform>().rect.height;
        progressbarImage.GetComponent<RectTransform>().sizeDelta = new Vector2 (
            progressbarImage.GetComponent<RectTransform>().rect.width,
            progressbarContainerHeight * rate
        );
    }
    
    public void SetForceMagnitude(string aForceMagnitude) {
        forceMagnitudeText.text = aForceMagnitude;
        SetProgresbar();
    }

    private void HitBall() {
        GameObject.FindGameObjectWithTag("Player").GetComponent<CueController>().HitBall();
    }

}
