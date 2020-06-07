using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

    [System.Serializable]
    public struct Pipe_Status
    {
        public bool top;
        public bool down;
        public bool right;
        public bool left;
    };


    public Pipe_Status status;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
