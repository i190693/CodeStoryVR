﻿using UnityEngine;
using Dossamer.Dialogue.Schema; 

namespace Dossamer.Dialogue
{
    public class DialogueTriggerBehavior : MonoBehaviour
    {

        // holds dialogue lines; passes them to dialogue manager when triggered

        public Cutscene dialogueToTrigger;

        [SerializeField]
        bool _onlyTriggerOnce = true;

        bool _isTriggered = false;

        public void TriggerDialogue()
        {
            if (!_onlyTriggerOnce || !_isTriggered)
            {
                Debug.Log("triggering dialogue");
                _isTriggered = true;
                DialogueManager.Instance.StartNewDialogue(dialogueToTrigger);
            }
        }
    }
}