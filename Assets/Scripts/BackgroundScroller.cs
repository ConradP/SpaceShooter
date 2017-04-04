using System;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {
    public Transform TopHalf, BottomHalf;
    private float resetY = 10.0f;
    private float limitY = -10.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        moveBackGround(TopHalf);
        moveBackGround(BottomHalf);
        scrollSwitch(TopHalf);
        scrollSwitch(BottomHalf);
	}

    private void scrollSwitch(Transform background)
    {
        if(background.position.y < limitY)
        {
            background.localPosition = new Vector3(background.localPosition.x, resetY, background.localPosition.z);
        }
    }

    private void moveBackGround(Transform background)
    {
        background.localPosition = new Vector3(background.localPosition.x, background.localPosition.y - 0.01f, background.localPosition.z);
    }

    
}
