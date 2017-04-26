using UnityEngine;

/*
    Author: Evan Otero
    Date:   April 25, 2017
    
    ObjectCollisionSound will play one of three AudioClips, depending on the velocity
    of the object when it enters a Collider.
    
    ***********************
    ******* LICENSE *******
    ***********************
    JoyceStick is a Boston College digital humanities project employing Unity
    to construct a virtual reality game from Joyce’s Ulysses for viewing on the
    HTC Vive, supported by a Teaching and Mentoring Grant and substantial funding
    from internal bodies at Boston College.
    Copyright (C) 2017  Evan Otero, Drew Hoo, Emaad Ali, Will Bowditch, Matt Harty, Jake Schafer, & Ryan Reede
    http://joycestick.bc.edu/

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

public class ObjectCollisionSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip crashLow, crashMedium, crashHigh;
    [SerializeField]
    private AudioSource source;

    private float velToVol = .2F, velocityClipSplit = 10F;

    void Awake() { }

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