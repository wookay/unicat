using UnityEngine;
using System.Collections;
using NUnitLite;

public class TestRunner : MonoBehaviour {
	
	// Use this for initialization
	void Start () {		
		ResultSummary result = NUnitLiteUnityRunner.RunTests();
		if (result.FailureCount > 0) {
			renderer.material.color = Color.red;
		} else if (result.TestCount > 0) {
			renderer.material.color = new Color(0.13f, 0.63f, 0.13f, 1);
		}
	}

	// Update is called once per frame
	void Update () {
	}	
}
