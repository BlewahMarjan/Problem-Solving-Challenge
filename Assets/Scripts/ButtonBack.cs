using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonBack : MonoBehaviour
{
    public void selectScene()
    {

        switch (this.gameObject.name)
        {
            case "ButtonBack":
                SceneManager.LoadScene("Gameplay10");
                break;
        }
    }
}
