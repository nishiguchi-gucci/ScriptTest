using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyakujun : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
