using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileIO : MonoBehaviour {

    public string fileName = "testFile.txt";

	// Use this for initialization
	void Start () {
        string finalFilePath = Application.dataPath + "/" + fileName;
        StreamWriter sw = new StreamWriter(finalFilePath, true);

        sw.WriteLine("this is a line");

        sw.Close();

        StreamReader sr = new StreamReader(finalFilePath);

        while (!sr.EndOfStream) {
            Debug.Log(sr.ReadLine());
        }
        sr.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
