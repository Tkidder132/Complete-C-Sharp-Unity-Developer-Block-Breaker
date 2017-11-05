using UnityEngine;

public class MusicPlayerController : MonoBehaviour
{

    static MusicPlayerController instance = null;

	// Use this for initialization
	void Start ()
    {
        if(instance)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate Music Player Destroyed");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
