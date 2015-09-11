using UnityEngine;
using System.Collections;

public class LookAtTransform : MonoBehaviour {

	public Transform m_gcLookAtTransform;
	public float m_fTurnSpeed;
	private Transform m_gcTransform;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vTraj = m_gcLookAtTransform.position - m_gcTransform.position;
		Quaternion qTargetRotation = Quaternion.LookRotation(vTraj, Vector3.up);
		Quaternion qLimitedRotation = Quaternion.Lerp(m_gcTransform.rotation, qTargetRotation, m_fTurnSpeed * Time.deltaTime);
		m_gcTransform.rotation = qLimitedRotation;
	}
}
