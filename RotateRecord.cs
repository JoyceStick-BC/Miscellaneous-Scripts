using UnityEngine;
using System.Collections;

public class RotateRecord : MonoBehaviour
{
    public float speed = 250f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up, speed * (3 * Time.deltaTime));
    }
}
