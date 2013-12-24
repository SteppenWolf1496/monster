using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour
{

		public enum Screens
		{
				START_MENU,
				CHOOSE_CAR_MENU,
				CHOOSE_MAP_MENU,
				GAME
		}


		

		private static int curScreen;


		public static void showScreen (int _name)
		{


				switch (_name) {
		case START_MENU: 

				}
		}



		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}

