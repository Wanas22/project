using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puse_system : MonoBehaviour {

	public  void PuseGame()
    {
        Time.timeScale = 0;

    }
    public void unPuseGame()
    {
        Time.timeScale = 1;

    }

}
