using UnityEngine;
using System.Collections;
using NUnitLite;

public class TestRunner : MonoBehaviour {
	public GameObject prefabPassed;
	public GameObject prefabFailed;
	
	// Use this for initialization
	void Start () {
		ResultSummary result = NUnitLiteUnityRunner.RunTests();
		for (int idx=0; idx < 5; idx++) {
			Instantiate(prefabPassed, new Vector3(idx*1.05f, -2, 0), Quaternion.identity);
		}		
		for (int idx=0; idx < result.FailureCount; idx++) {
			Instantiate(prefabFailed, new Vector3(idx*1.1f, 0, -2), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {
	}	
}
