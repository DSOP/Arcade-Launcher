﻿using System;
using System.Diagnostics;
using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

    public void Run(String path)
    {
        Process myProcess = new Process();
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        myProcess.StartInfo.CreateNoWindow = true;
        myProcess.StartInfo.UseShellExecute = false;
        myProcess.StartInfo.FileName = path;
        myProcess.EnableRaisingEvents = true;
        StartCoroutine(RunProcess(myProcess));
    }

    IEnumerator RunProcess(Process process)
    {
        Screen.fullScreen = false;
        yield return new WaitForSeconds(1f);
        process.Start();
        process.WaitForExit();
        Screen.fullScreen = true;
        Screen.showCursor = false;
    }
}
