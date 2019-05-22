using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CSD{

	public class UnityViewComponent : MonoBehaviour, IViewComponent {
		private IEntity entity;
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public bool SetEntity(IEntity entity){
			this.entity = entity;
			RefreshFromEntity ();
			return true;
		}

		public IEntity GetEntity(){
			return this.entity;
		}

		private void RefreshFromEntity(){
		}
	}
}