using BerserkPixel.Prata;
using UnityEngine;

namespace Project.Scripts.Player
{
    public class PlayerDialogInteractor : MonoBehaviour
    {
        private Interaction interaction;

        private PlayerInput playerInput;

        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void Update()
        {
            if (interaction != null && playerInput.Interact)
            {
                Interact();
            }
        }

        public void ReadyForInteraction(Interaction newInteraction)
        {
            interaction = newInteraction;
        }

        public void Interact()
        {
            if (interaction != null)
            {
                DialogManager.Instance.Talk(interaction);
            }
        }
    }
}