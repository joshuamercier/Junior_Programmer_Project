using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton design pattern, only one instance of GameManager will ever exist
public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static MainManager Instance;

    public Color TeamColor; // Color chosen by the player

    private void Awake()
    {
        // Prevents duplicates of GameManger from existing
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
