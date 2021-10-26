using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private float speed = 5.0f;
	public GameObject character;

	void Update()
	{

		if (Input.GetKey("d"))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey("a"))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		}
	}
