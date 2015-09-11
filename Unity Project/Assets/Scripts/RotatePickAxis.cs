using UnityEngine;
using System.Collections;

public class RotatePickAxis : MonoBehaviour {

	public Transform m_gcTransform;
	public enum tAxis
	{
		_Up,
		_Forward,
		_Right
	};

	public tAxis m_iDir = tAxis._Up;
	public float m_fDegrees;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		switch(m_iDir)
		{
			case tAxis._Up:
				m_gcTransform.Rotate(Vector3.up, m_fDegrees);
				break;

			case tAxis._Forward:
				m_gcTransform.Rotate(Vector3.forward, m_fDegrees);
				break;

			case tAxis._Right:
				m_gcTransform.Rotate(Vector3.right, m_fDegrees);
				break;
		}
	}
}
