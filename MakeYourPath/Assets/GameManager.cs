using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)) {
            var nextStates = state.GetNextStates();
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                state = nextStates[0];
            } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
                state = nextStates[1];
            }
            storyText.text = state.GetStateStory();
        }
    }
}
