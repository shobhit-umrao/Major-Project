using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{
    public static void SavePlayer(MoveByTouch moveByTouch)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/poly.bin";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(moveByTouch);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPLayer()
    {
        string path = Application.persistentDataPath + "/poly.bin";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            PlayerData data =  formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            //Debug.LogError("Save file does not exists in " + path);
            return null;
        }
    }
}