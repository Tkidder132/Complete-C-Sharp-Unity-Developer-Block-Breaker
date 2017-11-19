using UnityEngine;

public class PaddleController : MonoBehaviour
{
    float mousePosX;
    public bool autoPlay = false;

    private BallController ball;

    private void Start()
    {
        ball = FindObjectOfType<BallController>();
    }

    // Update is called once per frame
    void Update ()
    {
        if(!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }
	}

    void MoveWithMouse()
    {
        mousePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);
        transform.position = new Vector3(mousePosX, transform.position.y, 0);
    }

    void AutoPlay()
    {
        transform.position = new Vector3(ball.transform.position.x, transform.position.y, 0);
    }
}
