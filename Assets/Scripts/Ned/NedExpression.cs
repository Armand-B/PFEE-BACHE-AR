using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class NedExpression : MonoBehaviour
{
    [SerializeField] private List<Texture> nedExpressionTextures = new List<Texture>();
    public enum NedExpressions {Angry, Annoyed, Blink, Happy, Neutral, Sad, Surprised}
    public NedExpressions myNedExpression;
    [Header("Blink")]   [Range(0.01f, 1.0f)]public float speedBlink = 0.07f;
    public float intensityEmissive, speedEmissive;
    public Animator animatorEcran, animatorBody;
    public Renderer myMat;

    private float timer;
    private NedAudioManager nedAudioManager;

    private void Start()
    {
        nedAudioManager = GetComponent<NedAudioManager>();
        myNedExpression = NedExpressions.Neutral;
        ChangeExpression();
        StartCoroutine(NedMoveEyes());
    }

    void ChangeExpression()
    {
        int indexList = 4;
        switch (myNedExpression)
        {
            case NedExpressions.Angry:
                animatorBody.SetInteger("NedMoves", 7);
                nedAudioManager.PlayNedSound((int)Random.Range(0,13));
                indexList = 0;
                break;
            case NedExpressions.Annoyed:
                nedAudioManager.PlayNedSound((int)Random.Range(0, 13));
                indexList = 1;
                break;
            case NedExpressions.Blink:
                indexList = 2;
                break;
            case NedExpressions.Happy:                             
                animatorBody.SetInteger("NedMoves", Random.Range(4,6));
                nedAudioManager.PlayNedSound((int)Random.Range(0, 13));
                indexList = 3;
                break;
            case NedExpressions.Neutral:
                indexList = 4;
                break;
            case NedExpressions.Sad:
                animatorBody.SetInteger("NedMoves", 3);
                nedAudioManager.PlayNedSound((int)Random.Range(0, 13));
                indexList = 5;
                break;
            case NedExpressions.Surprised:
                animatorBody.SetInteger("NedMoves", 10);
                nedAudioManager.PlayNedSound((int)Random.Range(0, 13));
                indexList = 6;
                break;
        }
        myMat.material.SetTexture("_EmissionMap", nedExpressionTextures[indexList]);
        timer =  Time.time;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.05f);
        animatorBody.SetInteger("NedMoves", 0);
    }

    /// <summary>
    /// /////////////// TEST///////////////////
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Angry));
        } 
        else if(Input.GetKeyUp(KeyCode.Keypad2))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Annoyed));
        }
        else if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Happy));
        }
        else if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Neutral));
        }
        else if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Sad));
        }
        else if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            StartCoroutine(NedExpressionBlink(NedExpressions.Surprised));
        }
    }

    IEnumerator NedExpressionBlink(NedExpressions expression)
    {
        myNedExpression = NedExpressions.Blink;
        ChangeExpression();
        yield return new WaitForSeconds(speedBlink);
        myNedExpression = expression;       
        ChangeExpression();
        myMat.material.SetColor("_EmissionColor", Color.white * intensityEmissive);
        yield return new WaitForSeconds(speedEmissive);
        myMat.material.SetColor("_EmissionColor", Color.white * 1);
    }

    IEnumerator NedMoveEyes()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(2.5f, 4f));
            animatorEcran.SetInteger("IndexNedOffSet", Random.Range(1, 7));
            yield return new WaitForSeconds(1f);
            animatorEcran.SetInteger("IndexNedOffSet", 0);
            StartCoroutine(NedExpressionBlink(myNedExpression));
        }
    }
}
