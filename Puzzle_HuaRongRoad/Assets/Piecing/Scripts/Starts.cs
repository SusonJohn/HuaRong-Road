using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starts : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    
    //1min挑战
    public void play1 () {
        SceneManager.LoadScene ("pictruing2");
    }
    //无限时间、步数挑战
    public void play2(){
        SceneManager.LoadScene ("pictruing");
    }
}