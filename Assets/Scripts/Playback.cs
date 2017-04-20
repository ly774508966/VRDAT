using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using UnityEngine;

public class Playback : MonoBehaviour {

    private bool ReadRecording() {
        try {
            StreamReader reader = new StreamReader(Logger.path, Encoding.Default);
            string line;
            int counter = 0;

            while (!reader.EndOfStream) {
                line = reader.ReadLine();
                counter++;
            }

            reader.Close();
            Console.Write("loaded " + counter + "lines of data");
            return true;
        }
        catch (Exception e) {
            Debug.Log("ERROR - PLAYBACK - ReadRecording" + e);
            return false;
        }
    }
}
