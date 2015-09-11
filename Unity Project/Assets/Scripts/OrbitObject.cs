using UnityEngine;
using System.Collections;

public class OrbitObject : MonoBehaviour {

	public float m_fDistanceFromParent;
	public float m_fOrbitSpeed;

	private Transform m_gcTransform;
	private float m_fAngle;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vPos = new Vector3( Mathf.Sin(m_fAngle) * m_fDistanceFromParent, 0.0f, Mathf.Cos(m_fAngle) * m_fDistanceFromParent);
		m_gcTransform.localPosition = vPos;
		m_fAngle += m_fOrbitSpeed * Time.deltaTime;
	}
}
