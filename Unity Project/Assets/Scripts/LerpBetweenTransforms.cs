using UnityEngine;
using System.Collections;

public class LerpBetweenTransforms : MonoBehaviour {

	private Transform m_gcTransform;
	public Transform m_gcLerpPos1;
	public Transform m_gcLerpPos2;

	public float m_fLerpDuration;

	public float m_fEventTime;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
		m_fEventTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float fRatio = (Time.time - m_fEventTime) / m_fLerpDuration;

		m_gcTransform.position = Vector3.Lerp(m_gcLerpPos1.position, m_gcLerpPos2.position, fRatio);
		
		if (fRatio >= 1.0f)
		{
			Transform tTemp = m_gcLerpPos1;
			m_gcLerpPos1 = m_gcLerpPos2;
			m_gcLerpPos2 = tTemp;
			m_fEventTime = Time.time;
		}
	}
}
