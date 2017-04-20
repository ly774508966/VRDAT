using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour {

    public float timestep = 1.0f;
    private float timer;
    private bool recording;

    void StartRecording() {
        recording = true;
    }

    void FixedUpdate() {
        timer += Time.deltaTime;
    }
}
