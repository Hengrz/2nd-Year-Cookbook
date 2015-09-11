using UnityEngine;
using System.Collections;

public class InstantiateWithinRange : MonoBehaviour {
	public Transform m_gcInstantiateTransform;
	public Transform m_gcMoveToTransform;
	public float m_fDistance;
	
	private Transform m_gcTransform;

	// Use this for initialization
	void Start()
	{
		m_gcTransform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 vTraj = m_gcMoveToTransform.position - m_gcTransform.position;
		if( vTraj.magnitude < m_fDistance)
		{
			GameObject.Instantiate(m_gcInstantiateTransform, m_gcTransform.position, Quaternion.identity);
		}
	}
}
