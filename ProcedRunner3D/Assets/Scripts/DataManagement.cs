﻿using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataManagement : MonoBehaviour {

	public static DataManagement dataManagement;

	public int currentScore;
	public int highScore;
	public int coinsCollected;
	
	// make sure that there is always one dataManagement object 
	void Awake () {
		if (dataManagement == null) {
			DontDestroyOnLoad (gameObject);
			dataManagement = this;
		} 
		else if (dataManagement != this) {
			Destroy (gameObject);
		}
	}

	public void SaveData () {
		BinaryFormatter binForm = new BinaryFormatter();
		FileStream fs = File.Create ( Application.persistentDataPath + "\\gameInfo.dat");
		gameData data = new gameData ();
		data.highScore = highScore;
		data.coinsCollected = coinsCollected;
		binForm.Serialize (fs, data);
		fs.Close();
	}

	public void LoadData () {
		if (File.Exists (Application.persistentDataPath + "\\gameInfo.dat")) {
			BinaryFormatter binForm = new BinaryFormatter();
			FileStream fs = File.Open (Application.persistentDataPath + "\\gameInfo.dat", FileMode.Open);
			gameData data = (gameData)binForm.Deserialize (fs);
			fs.Close ();
			highScore = data.highScore;
			coinsCollected = data.coinsCollected;
		}
	}
}


[Serializable]
class gameData {

	public int highScore;
	public int coinsCollected;


}
