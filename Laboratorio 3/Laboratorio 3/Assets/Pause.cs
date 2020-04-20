using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool active;
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }

       
    }

   public void Continuar()
    {
        canvas.enabled = false;
        Time.timeScale = 1f;

    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
