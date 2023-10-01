using UnityEngine;

namespace Snake_Case
{
public class FallBird_snake_case : MonoBehaviour
{
    private Animator anim;
    private AudioSource au;

    private void Start()
    {
        anim = GetComponent<Animator>();
        au = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        anim.SetBool("isTap",true);
        au.Play();
    }

}
}
