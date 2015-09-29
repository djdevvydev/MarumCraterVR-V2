#pragma strict

function Awake ()
{
    Debug.Log("Awake called.");
}


function Start ()
{
	var credits1 : GameObject;
	var credits2 : GameObject;
	var credits3 : GameObject;
    var anim: Animation;

	credits1 = GameObject.Find("Credits_Plane_1");
	credits2 = GameObject.Find("Credits_Plane_2");
	credits3 = GameObject.Find("Credits_Plane_3");

    Debug.Log("Start called.");
    yield WaitForSeconds(4);
    Debug.Log("calling Animation.");
    anim=credits2.GetComponent.<Animation>();
    anim.Play();

    yield WaitForSeconds(4);
    Debug.Log("calling Animation.");
    anim=credits3.GetComponent.<Animation>();
    anim.Play();
    
}