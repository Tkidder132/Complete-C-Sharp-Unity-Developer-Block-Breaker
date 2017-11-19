using UnityEngine;

public class BrickController : MonoBehaviour
{
    public int maxHits;
    public int timesHit;
    public Color brickColor;

    private LevelManagerController levelManager;
    public GameObject smoke;

    // Use this for initialization
    void Start ()
    {
        levelManager = FindObjectOfType<LevelManagerController>();
        if (IsBreakable())
        {
            levelManager.brickCount++;
        }
        timesHit = 0;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(IsBreakable() && (++timesHit >= maxHits))
        {
            Destroy(gameObject);
            GameObject smokePuff = Instantiate(smoke, new Vector3(transform.position.x, transform.position.y, -10f ), Quaternion.identity);
            var main = smokePuff.GetComponent<ParticleSystem>().main;
            Debug.Log(brickColor);
            Debug.Log("Red: " + Color.red);
            main.startColor = brickColor;
            levelManager.brickCount--;
            levelManager.CheckBrickCount();
        }
    }

    bool IsBreakable()
    {
        return gameObject.tag.Equals("Breakable");
    }
}
