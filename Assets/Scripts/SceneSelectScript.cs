using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{

    public void selectScene() {

        switch (this.gameObject.name)
        {
            case "Button1":
                SceneManager.LoadScene("Gameplay1");
                break;
            case "Button2":
                SceneManager.LoadScene("Gameplay2");
                break;
            case "Button3":
                SceneManager.LoadScene("Gameplay3");
                break;
            case "Button4":
                SceneManager.LoadScene("Gameplay4");
                break;
            case "Button5":
                SceneManager.LoadScene("Gameplay5");
                break;
            case "Button6":
                SceneManager.LoadScene("Gameplay6");
                break;
            case "Button7":
                SceneManager.LoadScene("Gameplay7");
                break;
            case "Button8":
                SceneManager.LoadScene("Gameplay8");
                break;
            case "Button9":
                SceneManager.LoadScene("Gameplay9");
                break;
        }
    }
}
