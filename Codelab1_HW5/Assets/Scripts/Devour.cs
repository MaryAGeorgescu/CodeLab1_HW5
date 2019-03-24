using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devour : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Consume.");
        SceneManager.LoadScene(1);
        GameManager.instance.Score++;
    }
}
