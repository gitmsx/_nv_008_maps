using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class ReadMaps : MonoBehaviour
{

    [SerializeField] TextAsset MapsAll;

    GameObject Wall;
    GameObject Box;
    GameObject Player;
    GameObject Target;
    // GameObject Button;






    void Start()
    {
        int Level = 11;
        List<string> parsed = ReadData(Level);
        CreateLevel(parsed);
    }


    void CreateLevel(List<string> strings)
    {

        string[] strArr = strings.ToArray();

        // foreach (var str in strings)

        int axisY = 0;
        int axisX = 0;

        for (int i = 5; i < strings.Count - 2; i++)
        {

            char[] characters = strArr[i].ToCharArray();

            for (int j = 0; j < characters.Length; j++)

            {
                Debug.Log(characters[j]);
                RespBox(characters[j], axisX, axisY);
                axisX++;
                


            }
            axisY++;
        }


    }





    RespBox(char charN,int intx, int inty)
    {

        GameObject[] Tipes = new GameObject[4];

        Tipes[0] = Wall;
        Tipes[1] = Box;
        Tipes[2] = Player;
        Tipes[3] = Target;

        

        int elem = 1;

        switch (charN)
        {
            case "X":
                elem = 0;
            case ".":
                elem = 3;
            case " ":
                elem = -1;
            case "*":
                elem = 1;
            default:
                elem = -1;
            break;
        }
    }



    List<string> ReadData(int Level)
    {



        string path = "Assets\\Resources\\maps60.txt";
        path = "Assets/Resources/maps60.txt";
        List<string> parsed = new List<string>();
        string StartParse = "Maze: " + Level.ToString();
        string EndParse = "Maze: " + (Level + 1).ToString();
        bool WriteOn = false;


        try
        {
            using StreamReader sr = new StreamReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                if (EndParse == line)
                    break;
                if (StartParse == line)
                    WriteOn = true;
                if (WriteOn)
                    parsed.Add(line);



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



}
