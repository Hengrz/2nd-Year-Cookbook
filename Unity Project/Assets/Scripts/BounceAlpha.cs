using UnityEngine;
using System.Collections;

public class BounceAlpha : MonoBehaviour {

	public Material m_gcMaterial;
	public float m_fBounceSpeed;

	private float m_fAngle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		m_fAngle += m_fBounceSpeed * Time.deltaTime;
		m_gcMaterial.color = new Color(m_gcMaterial.color.r, m_gcMaterial.color.g, m_gcMaterial.color.b, Mathf.Sin(m_fAngle));
	}
}
