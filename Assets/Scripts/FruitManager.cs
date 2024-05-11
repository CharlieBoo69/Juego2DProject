using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{


    private void Update()
    {
        AllFruitCollected();
    }

    public void AllFruitCollected() {

        if (transform.childCount==0)
        {
            Debug.Log("Has recolectado todas las frutas, Victoria!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            PlayerPrefs.DeleteAll();

        }

    }

}
