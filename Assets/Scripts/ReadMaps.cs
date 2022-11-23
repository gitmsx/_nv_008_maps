using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadMaps : MonoBehaviour
{

    [SerializeField] TextAsset MapsAll;

    
    void Start()
    {
        int Level = 1;
      bool ReadFileBool = ReadData(Level);
    }


    bool ReadData(int Level)
    {
//        string path = "Assets/file.txt";
        var linesTxt = MapsAll.text;
 

        foreach(var  str in linesTxt )
            Debug.Log(str);

        return false;
    }


    void Update()
    {
        
    }
}
