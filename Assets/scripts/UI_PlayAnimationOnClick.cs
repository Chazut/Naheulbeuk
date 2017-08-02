using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PlayAnimationOnClick : MonoBehaviour {

    public int diceSize = 0;
    public Sprite[] spriteList;
    public GameObject diceAnimator;
    public GameObject InputField;

    private Animator _animator;
    private bool isClicked = false;

    private void Awake()
    {
        diceAnimator.SetActive(false);
        _animator = diceAnimator.GetComponent<Animator>();
        _animator.speed = 0;
        GetComponent<Image>().sprite = spriteList[0];
    }

    public void PlayAnimation()
    {
        if (isClicked)
            return;
        diceAnimator.SetActive(true);
        _animator.speed = 1;
        if (diceSize > 0)
        {
            StartCoroutine(Roll());
        }
    }


    private void OnMouseDown()
    {
        PlayAnimation();
    }

    private IEnumerator Roll()
    {
        int result = Random.Range(1, 7);
        yield return new WaitForSeconds(1);
        _animator.speed = 0;
        GetComponent<Image>().sprite = spriteList[result - 1];
        diceAnimator.SetActive(false);
        isClicked = true;
        GetComponent<Image>().color = Color.gray;
        InputField.GetComponent<InputField>().text = (result+7).ToString();
    }

}
