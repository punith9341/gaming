

using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Transform play;
    public Text doi;
	// Use this for initialization


	
	// Update is called once per frame
	void Update () {
        doi.text = (((play.position.z)+39)/10).ToString("0");
		
	}
}
