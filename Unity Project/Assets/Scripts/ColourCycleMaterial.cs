using UnityEngine;
using System.Collections;

public class ColourCycleMaterial : MonoBehaviour {

	public Material m_gcMaterial;
	public float m_fAngleR, m_fAngleB, m_fAngleG;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		m_gcMaterial.color = new Color(Mathf.Sin(m_fAngleR), Mathf.Sin(m_fAngleG), Mathf.Sin(m_fAngleB), 1.0f);

		m_fAngleR += 0.25f * Time.deltaTime;
		m_fAngleG += 1.0f * Time.deltaTime;
		m_fAngleB += 0.5f * Time.deltaTime;
	}
}
