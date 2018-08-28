
using UnityEngine;

public class playerController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        var xRotation = Input.GetAxis("Horizontal");
        var zMovement = Input.GetAxis("Vertical");

        transform.Rotate(0, xRotation, 0);
        transform.Translate(0, 0, zMovement);
	}
}
