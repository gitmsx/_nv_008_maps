using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadMaps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
