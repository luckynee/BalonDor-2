using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameOver lose;
    public GameObject kalah;
    public ControlManager ctrl;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        lose.ulang = true;
        ctrl.fail = 0;
        ctrl.score = 0;
        ctrl.total = 0;
        Time.timeScale = 1f;
    }
}
