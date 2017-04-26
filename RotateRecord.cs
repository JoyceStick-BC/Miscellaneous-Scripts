using UnityEngine;
using System.Collections;

/*
    Author: Evan Otero, Ryan Reede, and Drew Hoo
    Date:   April 25, 2017
    
    SoftFlicker will randomily change the intensity of a light.  It works by sampling perlin noise.
    Then, Time.time is used to step through these values smoothly over time. To avoid repetition among lights,
    a random value is generated. The intensity is only changed if the value falls between between minIntensity
    and maxIntensity. By adding a multiplier to Time.time, you can change how rapidly the light flickers.
    
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

public class RotateRecord : MonoBehaviour
{
    private float speed;

    void Start ()
    {
        speed = 250f;
    }
	
	void Update ()
    {
        transform.Rotate(Vector3.up, speed * (3 * Time.deltaTime));
    }
}
