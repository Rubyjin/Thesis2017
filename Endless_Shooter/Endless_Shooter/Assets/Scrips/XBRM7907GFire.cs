namespace VRTK.Examples{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class XBRM7907GFire : VRTK_InteractableObject {
		public GameObject muzzleFlash;
		public float magazineCapacity = 5;
		public float magazineRechargeTime = 0.5f;

		private AudioSource source;
	// Use this for initialization

		public override void StartUsing (VRTK_InteractUse usingObject) {
			base.StartUsing(usingObject);
		}

	void Start () {
		
	}
	

}
}