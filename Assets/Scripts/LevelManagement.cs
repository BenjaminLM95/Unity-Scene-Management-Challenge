using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{
    public GameObject player;
    public GameObject SpawnPosition;
    bool exit = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadMap1_1()
    {
        SceneManager.LoadScene(0);
        SceneManager.sceneLoaded += onSceneLoaded;

    }

    void LoadMap1_2()
    {
        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += onSceneLoaded;

    }

    void LoadMap1_3()
    {
        SceneManager.LoadScene(2);
        SceneManager.sceneLoaded += onSceneLoaded;

    }

    void onSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene: " + scene.name + "is loaded");

        if (scene.name == "Map1_1")
        {
            SpawnPosition = GameObject.Find("SpawnPoint01E");
            player.transform.position = SpawnPosition.transform.position - new Vector3(3f, 0f);
        }

        else if (scene.name == "Map1_2")
        {
            SpawnPosition = GameObject.Find("SpawnPoint2W");
            player.transform.position = SpawnPosition.transform.position + new Vector3(3f, 0f);
        }
        else if(scene.name == "Map1_3")
        {
            SpawnPosition = GameObject.Find("SpawnPoint3SW");
            player.transform.position = SpawnPosition.transform.position + new Vector3(0f, 3f);
        }
        Debug.Log(SpawnPosition.name);
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= onSceneLoaded;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.name == "SpawnPoint01E")
        {
            LoadMap1_2();
        }
        else if (collision.gameObject.name == "SpawnPoint2W")
        {

            LoadMap1_1();
        }
        else if (collision.gameObject.name == "SpawnPoint2NE")
        {

            LoadMap1_3();
        }
        else if (collision.gameObject.name == "SpawnPoint3SW")
        {
            LoadMap1_2();
        }
    }
    

}
