using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour {

    public int diceSize = 0;
    public Sprite[] spriteList;
    public GameObject diceAnimator;

    private Animator _animator;
    private bool isClicked = false;

    private void Awake()
    {
        diceAnimator.SetActive(false);
        _animator = diceAnimator.GetComponent<Animator>();
        _animator.speed = 0;
        GetComponent<SpriteRenderer>().sprite = spriteList[0];
    }

    public void PlayAnimation()
    {
        diceAnimator.SetActive(true);
        _animator.speed = 1;
        if (diceSize > 0)
        {
            StartCoroutine(Roll());
        }
    }


    private void OnMouseDown()
    {
        if (isClicked)
            return;
        PlayAnimation();
    }

    private IEnumerator Roll()
    {
        int result = Random.Range(1, 7);
        yield return new WaitForSeconds(1);
        _animator.speed = 0;
        GetComponent<SpriteRenderer>().sprite = spriteList[result-1];
        diceAnimator.SetActive(false);
        isClicked = true;
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

}
