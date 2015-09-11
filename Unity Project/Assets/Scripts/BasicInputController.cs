using UnityEngine;
using System.Collections;

public class BasicInputController : MonoBehaviour {

	public Transform m_gcTransform;
	public float m_fSpeed;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vTraj = Vector3.zero;
		vTraj.x = Input.GetAxis("Horizontal");
		vTraj.z = Input.GetAxis("Vertical");

		vTraj *= m_fSpeed *Time.deltaTime; //Introduce this later...

		m_gcTransform.position += vTraj;
	}
}
