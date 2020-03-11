using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager : MonoBehaviour {
    public GameObject ball1, ball2, ball3;
    private string filePath;

    private void Start() {
        filePath = Application.persistentDataPath +"/myFirstSaveFile.wissenoyuniki";
        Load();
    }

    public void Save() {
        //if (File.Exists(filePath))
        FileStream newStream = File.Create(filePath);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(newStream, ball1.transform.position.x);
        bf.Serialize(newStream, ball1.transform.position.y);
        bf.Serialize(newStream, ball1.transform.position.z);

        bf.Serialize(newStream, ball2.transform.position.x);
        bf.Serialize(newStream, ball2.transform.position.y);
        bf.Serialize(newStream, ball2.transform.position.z);

        bf.Serialize(newStream, ball3.transform.position.x);
        bf.Serialize(newStream, ball3.transform.position.y);
        bf.Serialize(newStream, ball3.transform.position.z);

        newStream.Close();

    }

    public void Load() {
        if (File.Exists(filePath)) {
            FileStream loadStream = File.Open(filePath, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();
            
            float ball1PosX = (float)bf.Deserialize(loadStream);
            float ball1PosY = (float)bf.Deserialize(loadStream);
            float ball1PosZ = (float)bf.Deserialize(loadStream);
            Vector3 ball1Position = new Vector3(ball1PosX, ball1PosY, ball1PosZ);

            float ball2PosX = (float)bf.Deserialize(loadStream);
            float ball2PosY = (float)bf.Deserialize(loadStream);
            float ball2PosZ = (float)bf.Deserialize(loadStream);
            Vector3 ball2Position = new Vector3(ball2PosX, ball2PosY, ball2PosZ);

            float ball3PosX = (float)bf.Deserialize(loadStream);
            float ball3PosY = (float)bf.Deserialize(loadStream);
            float ball3PosZ = (float)bf.Deserialize(loadStream);
            Vector3 ball3Position = new Vector3(ball3PosX, ball3PosY, ball3PosZ);

            loadStream.Close();

            ball1.transform.position = ball1Position;
            ball2.transform.position = ball2Position;
            ball3.transform.position = ball3Position;

        }
    } 

}
