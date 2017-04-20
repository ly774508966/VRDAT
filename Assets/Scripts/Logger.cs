using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Logger : MonoBehaviour {

    public static string path = "Assets/RECORDING.txt";
    private StreamWriter writer;

    public void OpenFile() {
        writer = new StreamWriter(path, false);
    }

    public void CloseFile() {
        writer.Close();
    }

    public void Write(string text) {
        if (writer != null)
            writer.WriteLine(text + '\n');
        else
            Debug.Log("LOGGER - Write - writer is null (no text file currently open)");
    }

}
