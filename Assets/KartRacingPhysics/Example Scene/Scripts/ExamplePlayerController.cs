using UnityEngine;
using System.Collections;

/// <summary>
/// A simple example player controller that takes keyboard/gamepad input and feeds it to the Kart
/// </summary>

[RequireComponent(typeof(KartController))]
public class ExamplePlayerController : MonoBehaviour 
{
	private KartController kart;

	void Start () 
	{
		// keep a reference to the kart component
		kart = GetComponent<KartController>();
	}
	
	void Update () 
	{
		// read the input from the controller, and send it straight to the kart controller
		kart.Thrust = Input.GetAxis("Vertical");
		kart.Steering = Input.GetAxis("Horizontal");


		// debug controls for triggering various things
		if(Input.GetKeyDown(KeyCode.S))
			kart.Spin(2.0f);
		
		if(Input.GetKeyDown(KeyCode.W))
			kart.Wiggle(2.0f);
		
		if(Input.GetKeyDown(KeyCode.J))
			kart.Jump(1.0f);
		
		if(Input.GetKeyDown(KeyCode.B))
			kart.SpeedBoost();

		if(Input.GetKeyDown (KeyCode.P))
			kart.SpeedPenalty();
	}
}
