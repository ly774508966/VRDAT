using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Logger {

    public static string path = "Assets/RECORDING.txt";
    static StreamWriter writer;

    public static void OpenFile() {
        writer = new StreamWriter(path, false);
    }

    public static void CloseFile() {
        writer.Close();
    }

    public static void Write(string text) {
        if (writer != null)
            writer.WriteLine(text + '\n');
        else
            Debug.Log("ERROR - LOGGER - Write - writer is null (no text file currently open)");
    }

}
