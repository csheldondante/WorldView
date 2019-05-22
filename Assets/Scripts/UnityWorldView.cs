using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CSD{
	public class UnityWorldView : MonoBehaviour, IWorldView<UnityViewComponent> {
		private WorldSim<UnityViewComponent, UnityWorldView> worldSim;
		private HashSet<UnityViewComponent> entityViews = new HashSet<UnityViewComponent>();

		// Use this for initialization
		void Start () {
			//check session data from previous run
			//if there was an in progress game load the world state and set any asset flags for view assets
			//start concurrent loading of view assets for menu
			//display the main menu
			//start concurrent loading of game assets
			//wait for user input to change the game state and transition to corresponding loading screen/game world

			//TEST CODE
			worldSim = new WorldSim<UnityViewComponent, UnityWorldView>(this);
			WorldSim<UnityViewComponent,UnityWorldView>.GetDistance (null, null);
			//END TEST CODE
		}
		
		// Update is called once per frame
		void Update () {
			if (worldSim == null)
				return;
			worldSim.Tick (Time.deltaTime);
		}

		public UnityViewComponent GetView(IEntity entity){
			var view = entity.GetComponent<UnityViewComponent> ();
			if (view != null)
				return view;
			var newView = CreateView (entity);
			entity.AddComponent (newView);
			return newView;
		}

		private UnityViewComponent CreateView(IEntity entity){
			return null;
		}
		public float GetDistance(IEntity obj1, IEntity obj2){
			return float.NaN;
		}

		public Objective GetRangeObjective(IEntity obj1, IEntity obj2){
			return null;
		}
		public WorldEvent MoveTo(IEntity entity, IEntity target){
			return null;
		}
	}
}