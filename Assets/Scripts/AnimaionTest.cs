using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaionTest : MonoBehaviour {

    public Transform start;
    public Transform end;
    public Color startColor;
    public Color endColor;

    float totalTime = 0;
	void Start () {
        transform.position = start.position;
	}
	
	// Update is called once per frame
	void Update () {
        totalTime += (Time.deltaTime / 3.0f);

        transform.position = Vector3.Lerp(start.position, end.position, totalTime);
        transform.rotation = Quaternion.Slerp(start.rotation, end.rotation, totalTime);
        GetComponent<MeshRenderer>().sharedMaterial.SetColor(0, Color.Lerp(startColor, endColor, totalTime));
    }
}
