using UnityEngine;

public class ObjectCollisionSound : MonoBehaviour
{
    public AudioClip crashLow, crashMedium, crashHigh;
    private AudioSource source;
    private float velToVol = .2F, velocityClipSplit = 10F;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        float hitVol = coll.relativeVelocity.magnitude * velToVol;

        if (coll.relativeVelocity.magnitude < velocityClipSplit / 2)
            source.PlayOneShot(crashLow, hitVol);

        else if (coll.relativeVelocity.magnitude < velocityClipSplit)
            source.PlayOneShot(crashMedium, hitVol);

        else
            source.PlayOneShot(crashHigh, hitVol);
    }
}