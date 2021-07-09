using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

sealed class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float maxHP, currentHP;
    public int candies, candiesPerLevel;
    
    
    private GameManager()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void LoadGame()
    {

    }

    void SaveGame()
    {

    }
}
