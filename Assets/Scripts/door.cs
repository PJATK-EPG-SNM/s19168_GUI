using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public int levelToLoad;
    private SceneSwitcher sceneSwitcher;
    void Start()
    {
        sceneSwitcher = GameObject.Find("SceneSwithcer").GetComponent<SceneSwitcher>();

    }

    
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        SceneSwitcher.LoadLevl(levelToLoad);
    //    }
    //}
}
