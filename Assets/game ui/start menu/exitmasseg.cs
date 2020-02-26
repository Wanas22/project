using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exitmasseg : MonoBehaviour
{
    [SerializeField] GameObject exit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);

            }
            else
            {

                if (exit)
                {
                    exit.SetActive(true);
                }
            }

        }

    }
    public void onUserClickYesNo(int choice)
    {

        if (choice == 1)
        {
            Application.Quit();
        }
        exit.SetActive(false);
    }

}

