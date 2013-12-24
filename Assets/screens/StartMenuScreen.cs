using UnityEngine;
using System.Collections;

public class StartMenuScreen : IScreen
{
		private MainGUI gui;

		override public void destroy ()
		{
				MonoBehaviour.Destroy (gui.gameObject);
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

				UnityEngine.Object pPrefab = Resources.Load ("perfabs/GUI/MainGUI");
				gui = (MonoBehaviour.Instantiate (pPrefab) as GameObject).GetComponent (typeof(MainGUI)) as MainGUI;
		
		}
}

