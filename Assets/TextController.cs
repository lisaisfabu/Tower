using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	//text of type Text 
	//public is access modifier. Text is a type. type is the name of the type Text.
	public Text text;
	private enum states {tower, sheets, walk, axe, window, room, door, bookcase, desk, drawer, letter, stairs, free};
	private states myState;

	// Use this for initialization
	void Start () {
		myState = states.tower;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == states.tower) 		{Tower ();} 
		else if (myState == states.walk) 		{Walk ();} 
		else if (myState == states.sheets) 		{Sheets ();} 
		else if (myState == states.axe) 		{Axe ();} 
		else if (myState == states.window) 		{Window ();}
		else if (myState == states.room) 		{Room ();} 
		else if (myState == states.door) 		{Door ();} 
		else if (myState == states.bookcase) 	{Book ();} 
		else if (myState == states.desk) 		{Desk ();} 
		else if (myState == states.drawer) 		{Drawer ();}
		else if (myState == states.letter) 		{Letter ();} 
		else if (myState == states.stairs) 		{Stairs ();} 
		else if (myState == states.free) 		{Free ();}
	}

	#region State Handeler Methods
	void Tower(){
		text.text = "You are locked in a tall tower and you are trying to escape. There are some nice clean sheets on the bed, "+
					"an axe on the floor, and a window to look outside.\n\n"+
					"Press W to walk around, S to pick up the clean sheets, A to pick the axe up, or L to look outside the window.";

		if 		(Input.GetKeyDown (KeyCode.W)) 			{myState = states.walk;} 
		else if (Input.GetKeyDown (KeyCode.S)) 			{myState = states.sheets;} 
		else if (Input.GetKeyDown (KeyCode.A)) 			{myState = states.axe;} 
		else if (Input.GetKeyDown (KeyCode.L)) 			{myState = states.window;}
	}

	void Walk(){
		text.text = "You walk around and you feel something funny in one part of the ground. You bend down to inspect it and the ground breaks.\n\n" +
					"Press space to wake up.";

		if 		(Input.GetKeyDown (KeyCode.Space)) 		{myState = states.room;}
	}

	void Sheets(){
		text.text = "You pick up the sheets and wrap yourself into a burrito.\n \"Ugh it's not time to play right now.\"\n\n" +
					"Press Backspace to go back.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.tower;}
	}

	void Axe(){
		text.text = "You check out the axe that's laying on the floor. We should keep it in case.\n\n" +
					"Press Backspace to go back.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.tower;}
	}

	void Window(){
		text.text = "You look out the window.\n \"Ah, fresh air for days.\"\n\n" +
					"Press Backspace to go back.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.tower;}
	}

	void Room(){
		text.text = "\"Ugh, uuh\" \n You awaken from your fall.\n \"Dang that hurt my tush.\"\n" +
					"You look around to see a locked door, a bookcase, and a desk.\n\n"+
					"Press B to check out the bookcase, L to check out the desk, and D to check out the door.";

		if 		(Input.GetKeyDown (KeyCode.B)) 			{myState = states.bookcase;} 
		else if (Input.GetKeyDown (KeyCode.L)) 			{myState = states.desk;} 
		else if (Input.GetKeyDown (KeyCode.D)) 			{myState = states.door;}
	}

	void Door(){
		text.text = "You shake the door, and it won't budge. Maybe you should use your axe?\n\n" +
					"Press Backspace to go back or press A to use your axe.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.room;} 
		else if (Input.GetKeyDown (KeyCode.A)) 			{myState = states.stairs;}
	}

	void Book(){
		text.text = "You read off the titles of the books.\n 'The Lengend of Santa Claws'\n 'The Runaway Princess'\n 'Cats Paradise'\n 'The Player and the Snake'\n"+
					"\"Wow there are a lot of books\"\n\n" +
					"Press Backspace to go back.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.room;}
	}

	void Desk(){
		text.text = "A nice sturdy desk. Do you want to open the desk drawer?\n\n" +
					"Press Backspace to go back or press O to open the drawer.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.room;} 
		else if (Input.GetKeyDown (KeyCode.O)) 			{myState = states.drawer;}
	}

	void Drawer(){
		text.text = "You pull the drawer open. There is a bunch of garbage and a letter inside.\n\n" +
					"Press Backspace to go back or press P to pick up letter.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.desk;} 
		else if (Input.GetKeyDown (KeyCode.P)) 			{myState = states.letter;}
	}

	void Letter(){
		text.text = "'Dearest Elizabeth,\n I have longed to tell you the truth. But I love you and want to keep you away from this as long as "+
					"possible. But I fear that we can not keep it from you any longer. You are..' \n \"What the hell?? The paper is just torn at that part..\"\n\n" +
					"Press Backspace to go back.";

		if 		(Input.GetKeyDown (KeyCode.Backspace)) 	{myState = states.desk;}
	}

	void Stairs(){
		text.text = "\"Ohh. Nice one axe.\" There are stairs leading down to somewhere.\n\n" +
					"Press Backspace to go back or press W to walk down the stairs.";

		if 		(Input.GetKeyDown (KeyCode.Backspace))	{myState = states.room;} 
		else if (Input.GetKeyDown (KeyCode.W)) 			{myState = states.free;}
	}

	void Free(){
		text.text = "Yes a door to freedom. \"Finally I'm out of that stuffy tower!\" \n\n" +
					"Press P to play again!";

		if 		(Input.GetKeyDown (KeyCode.P)) 			{myState = states.tower;}
	}
	#endregion
}
