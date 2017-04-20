using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour {

    public float timestep = 1.0f;
    private float timer;
    private bool recording;

    public GameObject leftController;
    public GameObject rightController;
    public GameObject head;

    void StartRecording() {
        recording = true;
        Logger.OpenFile();
    }

    void StopRecording() {
        recording = false;
    }

    void FixedUpdate() {
        timer += Time.deltaTime;
    }

    void FormatData(Tick leftHand, Tick rightHand, Tick head) {
        
    }
}
