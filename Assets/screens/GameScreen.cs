using UnityEngine;
using System.Collections;

public class GameScreen : IScreen
{
		private	TerrainDisplayer terrain;
		private TruckControll truck;
		private GUITest truckGUI;

		override public void destroy ()
		{

				MonoBehaviour.Destroy (terrain.gameObject);
				MonoBehaviour.Destroy (truck.gameObject);
				MonoBehaviour.Destroy (truckGUI.gameObject);
		}
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		override public void create ()
		{
		
				UnityEngine.Object pPrefab = Resources.Load ("perfabs/terrains/terrain1");
				terrain = (MonoBehaviour.Instantiate (pPrefab) as GameObject).GetComponent (typeof(TerrainDisplayer)) as TerrainDisplayer;
		
				pPrefab = Resources.Load ("perfabs/GUI/GUI");
				truckGUI = (MonoBehaviour.Instantiate (pPrefab) as GameObject).GetComponent (typeof(GUITest)) as GUITest;
		
				pPrefab = Resources.Load ("perfabs/cars/" + Model.curCar);
				truck = (MonoBehaviour.Instantiate (pPrefab) as GameObject).GetComponent (typeof(TruckControll)) as TruckControll;
		
				truckGUI.truck = truck;
		
		}
}

