using UnityEngine;
using System.Collections;

public class FollowTransform : MonoBehaviour {

	public Transform m_gcFollowTarget;
	public Vector3 m_vOffset;
	public float m_fLag;

	private Transform m_gcTransform;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vPos = m_gcFollowTarget.position + m_vOffset;
		m_gcTransform.position = Vector3.Lerp(m_gcTransform.position, vPos, m_fLag * Time.deltaTime);
	}
}
