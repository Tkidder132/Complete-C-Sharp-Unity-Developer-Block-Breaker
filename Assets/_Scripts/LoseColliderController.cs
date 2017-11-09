using UnityEngine;

public class LoseColliderController : MonoBehaviour
{
    public LevelManagerController levelManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        levelManager.LoadLevel("Lose");
    }
}
