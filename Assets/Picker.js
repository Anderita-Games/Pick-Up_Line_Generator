/*  -----------------------
	Made by Andrew Friedman
	6/3/17 1:10 AM
	Sh!t is fye ;)
	-----------------------  */
	
#pragma strict
import System.IO; //For Reading TXT

var StartText : GameObject;
var RandoNumbo : int;

var sr : StreamReader;
var List : TextAsset;
var TheLine : UnityEngine.UI.Text;

function Start () {
	//List = Resources.Load("Lines", typeof(TextAsset));
}

function Generate () {
	StartText.SetActive (false);
	RandoNumbo = Random.Range(1,401);
	sr = new StreamReader(new MemoryStream(List.bytes));
	while (RandoNumbo > 0) {
		TheLine.text = sr.ReadLine();
		RandoNumbo--;
	}
	sr.Close();
}