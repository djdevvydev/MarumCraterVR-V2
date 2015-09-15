using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

    public Transform menuCanvas;
	
	// Update is called once per frame
	void Update () 
    {
        menuCanvas.position = transform.position + (Vector3.down * 1.5F);
	}
}
