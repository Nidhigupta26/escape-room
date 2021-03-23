using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        string collided = collision.gameObject.tag;
        print("collided");
        Loadnextlevel();
    }

    private void Loadnextlevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
}
