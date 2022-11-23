using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ReadMaps : MonoBehaviour
{

    [SerializeField] TextAsset MapsAll;


    void Start()
    {
        int Level = 11;
        List<string> parsed = ReadData(Level);
    }


    List<string> ReadData(int Level)
    {



        string path = "Assets\\Resources\\maps60.txt";
        path = "Assets/Resources/maps60.txt";
        List<string> parsed = new List<string>();
        string StartParse = "Maze: " + Level.ToString();
        string EndParse = "Maze: " + (Level + 1).ToString();

        //Debug.Log(StartParse);
        //Debug.Log(EndParse);



        bool WriteOn = false;


        try
        {
            using StreamReader sr = new StreamReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                if (EndParse == line) { Debug.Log(line); break; }
                if (StartParse == line) WriteOn = true;
                if (WriteOn)
                {
                    parsed.Add(line);
                    Debug.Log(line);
                }

            }
            sr.Close();
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        
        return parsed;
    }


    void Update()
    {

    }
}
