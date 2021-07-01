using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_die : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("dead");
            this.enabled = false;
            GetComponent<Collider2D>().enabled = false;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
