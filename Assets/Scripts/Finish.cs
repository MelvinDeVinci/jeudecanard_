using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D truc) {
        if (truc.tag == "Finish") {
            SceneManager.LoadScene("Menu 2");
    }
}
}
