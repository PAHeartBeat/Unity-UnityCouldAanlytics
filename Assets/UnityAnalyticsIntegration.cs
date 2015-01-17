using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Cloud.Analytics;

public class UnityAnalyticsIntegration : MonoBehaviour {
	
	const string appId = "201e590cc1cd44b2a633b01ac8119ab5";
	// Use this for initialization
	void Start () {
		UnityAnalytics.StartSDK (appId);
		UnityAnalytics.CustomEvent ("Events", new Dictionary<string,object >{
			{"Action","App Start"}
		});
		UnityAnalytics.SetUserBirthYear (1984);
		UnityAnalytics.SetUserGender (SexEnum.M);
		UnityAnalytics.SetUserId ("PAHeartBeat");
	}
	void OnApplicationPause(bool isPaused){
		Debug.Log (isPaused ? "App Pause" : "App Resume");
		UnityAnalytics.CustomEvent ("Events", new Dictionary<string,object >{
				{"Action",isPaused ? "App Pause" : "App Resume"}
			});
	}
	void OnApplicationQuit(){
		Debug.Log ("App Close");
		UnityAnalytics.CustomEvent ("Events", new Dictionary<string,object >{
			{"Action","AppClose"}
		});
	}
}