using UnityEngine;

public class LoseColliderController : MonoBehaviour
{
    private LevelManagerController levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManagerController>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("Lose");
    }
}
