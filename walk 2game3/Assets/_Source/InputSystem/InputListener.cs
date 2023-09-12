using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode jumpKey;
        [SerializeField] private PlayerComponent _playerComponent;
        private PlayerInvoker _playerInvoker;

        void Start()
        {
            _playerInvoker = new PlayerInvoker(_playerComponent);

        }
        void Update()
        {
            ReadJumpKey();
            ReadOffInputKey();
            ReadMove();
        }

        private void ReadMove()
        {
            _playerInvoker.Move();
        }
        private void ReadJumpKey()
        {
            if (Input.GetKeyDown(jumpKey))
            {
                _playerInvoker.Jump();
            }
        }

        private void ReadOffInputKey()
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                //coding
            }
        }
    }
}