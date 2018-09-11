
using UnityEngine;

public class playerController : MonoBehaviour {
	// Use this for initialization
    private SteamVR_TrackedObject trackedObj;
	
	private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }
	void Awake(){
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update () {
        var xRotation = Input.GetAxis("Horizontal");
		
		
		
        //var zMovement = Input.GetAxis("Vertical");

		while (Controller.GetHairTriggerDown()){
			transform.Translate(0, 0, 5);
		}
		transform.Rotate(0, xRotation, 0);
        
	}
}
