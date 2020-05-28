using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class profilo_ouveture_porte2 : MonoBehaviour {

public float gizmoSize = .75f;
public Color gizmoColor = Color.yellow;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere(transform.position, gizmoSize);
	}
	
	
	void onDrawGizmo(){
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere(transform.position, gizmoSize);
	}
}
