using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    private bool finished= false;

    void  Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(finished ){
            SceneManager.LoadScene(3);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            NextSentence();
        }
    }

    void NextSentence()
    {
        if(Index <=Sentences.Length -1){
            DialogueText.text = "";
            StartCoroutine(WriteSentences());
        }else{
            finished = true;
        }
    }

    IEnumerator WriteSentences()
    {
        foreach (char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);

        }
        Index++;
    }
}
