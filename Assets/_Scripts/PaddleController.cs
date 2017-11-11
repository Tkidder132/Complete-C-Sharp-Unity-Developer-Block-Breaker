using UnityEngine;

public class PaddleController : MonoBehaviour
{
    float mousePosX;
	
	// Update is called once per frame
	void Update ()
    {
        mousePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);
        transform.position = new Vector3(mousePosX, transform.position.y, 0);
	}
}
