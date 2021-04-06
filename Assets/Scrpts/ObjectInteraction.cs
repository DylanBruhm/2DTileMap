using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectInteraction : MonoBehaviour
{
    [Header("Used for objects that give simple info about themselves")]
    public bool info;
    public string message;
    private Text infotext;

    [Header("this object can be picked up")]
    [Space]
    public bool pickup;

    [Header("Npc Text")]
    [Space]
    public bool talks;
    [TextArea]
    public string[] sentences;
    public void Info()
    {

        StartCoroutine(ShowInfo(message, 2.5f));
    }
    public void Pickup()
    {
        Debug.Log("You Picked " + this.gameObject.name);
        this.gameObject.SetActive(false);
    }
    public void Talks()
    {
        Debug.Log("hello");
        FindObjectOfType<DialogueManager>().StartDialogue(sentences);
    }
    IEnumerator ShowInfo(string message, float delay)
    {
        infotext.text = message;
        yield return new WaitForSeconds(delay);
        infotext.text = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        infotext = GameObject.Find("InfoText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
