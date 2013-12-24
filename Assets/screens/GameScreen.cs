using UnityEngine;
using System.Collections;

public class GameScreen : MonoBehaviour
{
		private	TerrainDisplayer terrain;
		private TruckControll truck;
		private GUITest truckGUI;

		~GameScreen ()
		{
				Destroy (terrain);
				Destroy (truck);
				Destroy (truckGUI);
		}
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		private void createGame ()
		{
		
				UnityEngine.Object pPrefab = Resources.Load ("perfabs/terrains/terrain1");
				terrain = (Instantiate (pPrefab) as GameObject).GetComponent (typeof(TerrainDisplayer)) as TerrainDisplayer;
		
				pPrefab = Resources.Load ("perfabs/GUI/GUI");
				truckGUI = (Instantiate (pPrefab) as GameObject).GetComponent (typeof(GUITest)) as GUITest;
		
				pPrefab = Resources.Load ("perfabs/cars/truck1");
				truck = (Instantiate (pPrefab) as GameObject).GetComponent (typeof(TruckControll)) as TruckControll;
		
				truckGUI.truck = truck;
		
		}
}

