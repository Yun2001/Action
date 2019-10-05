using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Scene : MonoBehaviour {

    public enum sceneName
    {
        TItle,
        StageSelect,
        GameMain,
        Result
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //制作停止
    //void SceneChange()
    //{
    //    switch (sceneName)
    //    {
    //        case TItle:
    //            SceneManager.LoadSceneAsync("StageSelect", LoadSceneMode.Single);
    //            break;
    //        case 1:
    //            SceneManager.LoadSceneAsync("StageSelect", LoadSceneMode.Single);
    //            break;
    //        case 2:
    //            SceneManager.LoadSceneAsync("StageSelect", LoadSceneMode.Single);
    //            break;
    //    }          
    //}



}
