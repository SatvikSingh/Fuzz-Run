using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float maxHeight;
    public float minHeight;
    public float speed;
    public Animator camAnim;
    public GameObject MoveEffect;

    private Vector2 targetPos;
    private float Yincrement = 2.5f;

    public int PlayerHP = 3;

    public Text HealthDisp;
    public GameObject GameOverDisp;
    public GameObject GameAudio;
    public AudioSource MoveSound;

    void Update()
    {
        HealthDisp.text = PlayerHP.ToString();

        if (PlayerHP <= 0)
        {
            GameAudio.GetComponent<Animation>().Play("Audio_Decrease");
            GameOverDisp.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.y<maxHeight)
            {
                MoveSound.Play();
                targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                camAnim.SetTrigger("shake");
                Instantiate(MoveEffect, transform.position, Quaternion.identity);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.y>minHeight)
            {
                MoveSound.Play();
                targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
                camAnim.SetTrigger("shake");
                Instantiate(MoveEffect, transform.position, Quaternion.identity);
            }
        }
    }
}
