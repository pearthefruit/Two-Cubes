using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textPrompt : MonoBehaviour {
	public Transform other;

		GameObject UFO;
		GameObject Treasure;
		bool win = false;
	public Text uiTextObject;
	// Use this for initialization
	void Start () {
			UFO = GameObject.Find("ufo");
			Treasure = GameObject.Find ("Wall");


	}
	
	// Update is called once per frame
	void Update () {
			if (win == false ){
				float dist = Vector3.Distance(Treasure.transform.position, UFO.transform.position);
				string textBuffer = "\nDistance to treasure: " + dist.ToString();
				if ( dist >= 888 ){
			//	 (textBuffer += "\nKeep looking.");
				uiTextObject.text = "stuff";
				}
				else if ( dist <= 888  && dist >= 200  ){
				uiTextObject.text = "\nYou're near.";	
				}
				else if ( dist < 200 ) {
				uiTextObject.text = "\nPress Space to collect your reward.";
					
					if ( Input.GetKeyDown (KeyCode.Space) ) {
						win = true;
					}
				}
			}
			else if (win == true ){

				uiTextObject.text = "\nCongratulations!  You have found the treasure.";
				
			}
	}
}
