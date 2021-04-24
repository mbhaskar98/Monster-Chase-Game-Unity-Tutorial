using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    private float movementX;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";

    private void Awake()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
        // Debug.Log(sr.sprite);

        // Sprite[] t = Resources.LoadAll<Sprite>("Players");
        // sr.sprite = t[8];
        // Debug.Log(t[8]);
        // Image m_Image = GetComponent<Image>();

        //  Debug.Log(m_Image);

        // Debug.Log(anim.runtimeAnimatorController.animationClips[0].length);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();

       
        
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        gameObject.GetComponent<Transform>().position += (new Vector3(movementX, 0f, 0f)) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer()
    {

        // We are going to right side
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
}
