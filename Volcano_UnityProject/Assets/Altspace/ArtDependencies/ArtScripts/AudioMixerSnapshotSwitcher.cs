using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerSnapshotSwitcher : MonoBehaviour {
	
	public AudioMixer Mixer;
	public AudioMixerSnapshot SnapshotInside;
	public AudioMixerSnapshot SnapshotOutside;
	public float TransitionTime = 0.5f;
	
	private GameObject playerObject;
	
	void OnTriggerEnter( Collider other ) {
		HandleTrigger( other, SnapshotInside );
	}
	
	void OnTriggerExit( Collider other ) {
		HandleTrigger( other, SnapshotOutside );
	}
	
	private void HandleTrigger( Collider other, AudioMixerSnapshot snapshot ) {
		GetPlayerGameObject();
		if( playerObject != other.gameObject ) return;

		if (snapshot != null) {
			snapshot.TransitionTo (TransitionTime);
		} else {
		}
	}
	
	private void GetPlayerGameObject() {
		if( playerObject != null ) return;
		
		#if ALTSPACE_UNITYCLIENT
		if( Main.PlayerManager != null  &&  Main.PlayerManager.Me != null ) {
			playerObject = Main.PlayerManager.Me.gameObject;
		}
		#else
		foreach (var gameObjectName in new string[] { "First Person Controller","FPSController", "FirstPersonController", "OVRPlayerController" }) {
			playerObject = GameObject.Find (gameObjectName);
			if (playerObject != null) break;
		}

		#endif
	}
}

