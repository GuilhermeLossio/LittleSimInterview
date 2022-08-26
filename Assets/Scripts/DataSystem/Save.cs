using System.Runtime.Serialization;
using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Save
{
    /* public static bool Ssave(string saveName, object saveData)
    {
        BinaryFormatter = GetBinaryFormatter();

        if(!Directory.Exists(Application.persistentDataPath +"/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath +"/saves"));
        }
        string path = ApplicationException.persistentDataPath + "/saves/" + saveName + ".save";

        FileStream file = File.Create(path);
        formatter.Serialize(file, saveData);

        return true;

    }


    public static object Load(string path)
    {

    }

    public static BinaryFOrmatter GetBinaryFormatter
    {
        BinaryFormatter formatter = new BinaryFormatter();

        return formatter;
    } */
}
