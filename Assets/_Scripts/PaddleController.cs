using UnityEngine;

public class PaddleController : MonoBehaviour
{
    float mousePosX;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        mousePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);
        this.transform.position = new Vector3(mousePosX, this.transform.position.y, 0);
	}
}
