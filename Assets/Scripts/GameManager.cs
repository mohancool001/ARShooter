using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager Instance{ set; get; }

	public List<GameObject> allblocks;
	public GameObject[] levelPrefab;
	public int currentLevel =0;

	private void Awake()
	{
		Instance = this;
		DontDestroyOnLoad (this.gameObject);

		//Load Content


		//Loaded Content
		ChangeScene("Menu");
	}

	public void ChangeScene(string scenen)
	{
		SceneManager.LoadScene (scenen);
	}

	public void OnLevelWasLoaded(int levelIndex){
		if (SceneManager.GetActiveScene ().name == "ARShooter") {

			if (currentLevel < levelPrefab.Length)
				Instantiate (levelPrefab [currentLevel]);
			else
				ChangeScene ("Menu");
			
			GameObject[] a = GameObject.FindGameObjectsWithTag ("Blocks");
			allblocks = new List<GameObject> ();
			allblocks.AddRange (a);


		}
	}
	public void RemoveBlock(GameObject block)
	{
		if(allblocks.Find(b=>b == block))
			allblocks.Remove(block);

		if (allblocks.Count == 0)
			Victory ();
			//Victory
	}

	public void Victory(){
		currentLevel++;
		ChangeScene ("Game");
	}
}


