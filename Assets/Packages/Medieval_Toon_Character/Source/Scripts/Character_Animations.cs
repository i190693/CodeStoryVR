using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Animations : MonoBehaviour
{
    private Animator animator;
    private float v, h, run;
    float ttime = 10f;
    float time = 10f;

    float sprintt;
    bool will_sprint = false;
    int hrand, wrand;
    float ww, hh;
    void Start()
    {
        animator = GetComponent<Animator>();
        sprintt = Random.Range(0, 1);
        ww= Random.Range(0, 1);
        hh= Random.Range(0, 1);
        if (ww > 0.5)
        {
            wrand = 1;
        }
        else if (ww < 0.5)
        {
            wrand = -1;
        }
        else
        {
            wrand = 0;
        }
        if (hh > 0.5)
        {
            hrand = 1;
        }
        else if (hh < 0.5)
        {
            hrand = -1;
        }
        else
        {
            hrand = 0;
        }
    }

    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        if (animator.GetFloat("Run") == 0.2f)
        {
            if (Random.Range(0,1)>0.8)
            {
                animator.SetBool("Jump", true);
            }
        }
        Sprinting();
    }

    void FixedUpdate()
    {
        animator.SetFloat("Walk", wrand);
        animator.SetFloat("Run", run);
        animator.SetFloat("Turn", hrand);

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = ttime;
            sprintt = Random.Range(0, 1);
            ww = Random.Range(0, 1);
            hh = Random.Range(0, 1);
            if (ww > 0.5)
            {
                wrand = 1;
            }else if (ww < 0.5)
            {
                wrand = -1;
            }
            else
            {
                wrand = 0;
            }
            if (hh > 0.5)
            {
                hrand = 1;
            }
            else if (hh < 0.5)
            {
                hrand = -1;
            }
            else
            {
                hrand = 0;
            }
        }
    }

    void Sprinting()
    {
        if (sprintt > 0.5)
            run = 0.2f;
        else
            run = 0.0f;
    }
}