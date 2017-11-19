using UnityEngine;

public class BallController : MonoBehaviour
{
    private PaddleController paddle;
    private Vector3 paddleToBallVector;
    private AudioSource boing;
    private Rigidbody2D ball;
    bool gameStarted = false;

	// Use this for initialization
	void Start ()
    {
        paddle = FindObjectOfType<PaddleController>();
        boing = FindObjectOfType<AudioSource>();
        ball = FindObjectOfType<Rigidbody2D>();
        paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!gameStarted)
        {
            transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                print("Mouse Clicked, launching ball");
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                gameStarted = true;
            }
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.3f));
        ball.velocity += tweak;
        if (collision.collider.tag.Equals("Breakable"))
        {
            boing.Play();
        }
    }
}
