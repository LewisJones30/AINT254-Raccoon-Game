using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingameUI : MonoBehaviour
{
    [SerializeField]
    Text objectiveText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ObjectiveText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ObjectiveText()
    {
        //Show the objective text for 5 seconds.
        objectiveText.enabled = true;
        yield return new WaitForSeconds(5);
        objectiveText.enabled = false;
    }
}
