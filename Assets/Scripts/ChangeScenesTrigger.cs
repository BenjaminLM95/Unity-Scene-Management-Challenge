using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenesTrigger : MonoBehaviour
{

    
    public string sceneName;
    public string spawnPoint; 
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision");

        if (collision.gameObject.CompareTag("Player")){

            GameManager.Instance._levelManagement.LoadSceneWithSpawnPoint(sceneName, spawnPoint);  
        }
    }
}
