using UnityEngine;
using System.Collections;

public class Main : EmptyDicePlusListener, IDicePlusConnectorListener {
	public GUIText UTRollResult;
	
	// Use this for initialization
	void Start () {
		DicePlusConnector.Instance.registerListener(this);
	}
	
	public void onConnectionEstablished (DicePlus dicePlus) {
		dicePlus.registerListener(this);
		dicePlus.subscribeRolls();
	}
	
	public override void onRoll (DicePlus dicePlus, long time, int duration, int face, int invalidityFlags, string errorMsg) {
		
		// Accepting only valid rolls.
		if(invalidityFlags == 0) {
			UTRollResult.text = face.ToString();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	#region IDicePlusConnectorListener implementation
	public void onNewDie (DicePlus dicePlus)
	{
		
	}

	public void onScanFinished (bool fail)
	{
		
	}

	public void onScanStarted ()
	{
		
	}

	public void onConnectionLost (DicePlus dicePlus)
	{
		
	}

	public void onConnectionFailed (DicePlus dicePlus, string excpMsg)
	{
		
	}
	#endregion
}
