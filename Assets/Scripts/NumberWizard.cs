using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	int guessCount = 0;

	private void _intro() {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me.");
	}

	private void _minMax() {
		int max = 1000;
		int min = 1;
		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
	}

	private void _gameOver() {
		print ("I won!");
	}

	private void _guess() {
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down arrow for lower, and return for equal.");
		guessCount++;
	}

	private void _guessTooLow() {
		print (guess + " was too low.");
		min = guess;
		_setNewGuess ();
		_guess ();
	}

	private void _guessTooHigh() {
		print (guess + " was too high.");
		max = guess;
		_setNewGuess ();
		_guess ();
	}

	private void _newGame() {
		max = 1000;
		min = 1;
		guess = 500;
		guessCount = 0;

		_intro ();
		_minMax ();
		_guess ();
	}

	private void _setNewGuess() {
		guess = (max + min) / 2;
	}

	// Use this for initialization
	void Start () {
		_newGame ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			_guessTooLow ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			_guessTooHigh ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			_gameOver ();
		}
	}
}
