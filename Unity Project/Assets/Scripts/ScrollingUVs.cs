using UnityEngine;
using System.Collections;

public class ScrollingUVs : MonoBehaviour {
	
	public Mesh m_gcMesh;
	public float m_fScrollSpeed;
	
	void Start()
	{
		m_gcMesh = this.transform.GetComponent<MeshFilter>().mesh;
	}

	void LateUpdate()
	{

		Vector2[] vMeshUV = m_gcMesh.uv;


		for (int i = 0; i < vMeshUV.Length; i++)
		{
			vMeshUV[i] += new Vector2(0, m_fScrollSpeed * Time.deltaTime);
		}

		m_gcMesh.uv = vMeshUV;
	}
}
