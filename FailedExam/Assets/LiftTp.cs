using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiftTp : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Scene scene;
    private bool _enabled;
    void Start()
    {
        animator = GetComponent<Animator>();
        scene = SceneManager.GetActiveScene();
        if(scene.name == "SampleScene")
        {
           _enabled = true;
            Debug.Log(enabled);
        }
        else
        {
            _enabled = false;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_enabled)
        {
            if (collision.tag == "Player")
            {
                animator.SetBool("isOpen", true);
            }
        }
        else
        {
            Debug.Log("tp disabled");
        }
        
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetBool("isOpen", false);
        }
    }
    void TpPlayer()
    {
        SceneManager.LoadScene("Test Scene");
    }
}