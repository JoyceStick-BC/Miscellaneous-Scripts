using UnityEngine;

[RequireComponent(typeof(Light))]
public class SoftFlicker : MonoBehaviour
{
    [SerializeField]
    private float minIntensity;
    [SerializeField]
    private float maxIntensity;

    private float random;

	// Use this for initialization
	void Start ()
    {
        random = Random.Range(0.0f, 65535.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        light.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
	}
}
