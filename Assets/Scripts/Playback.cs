using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class Playback : MonoBehaviour {

    private bool ReadRecording() {
        try {
            StreamReader reader = new StreamReader(Logger.path, Encoding.Default);
            string line;
            int counter;

            while (!reader.EndOfStream) {
                line = reader.ReadLine();
                counter++;
            }

            reader.Close();
            Console.Log("loaded " + counter + "lines of data");
            return true;
        }
        catch (Exception e) {
            Debug.Log("{0}\n", e.message);
            return false;
        }
    }
}
