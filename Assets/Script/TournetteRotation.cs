using System.Collections;
using UnityEngine;

public class Gizmo : MonoBehaviour {

public float gizmoSize = .75f;
public Color gizmoColor = Color.yellow;

	void onDrawGizmo(){
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere(transform.position, gizmoSize);
	}
}
