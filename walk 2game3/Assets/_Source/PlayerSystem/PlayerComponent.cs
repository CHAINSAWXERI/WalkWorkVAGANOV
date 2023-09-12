using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof (Rigidbody))]
    public class PlayerComponent : MonoBehaviour
    {
        [SerializeField] private float MovSpeed;
        public float movSpeed => MovSpeed;
        [SerializeField] private float RotSpeed;
        public float rotSpeed => RotSpeed;
        [SerializeField] private float JumpForce;
        public float jumpForce => JumpForce;
        [SerializeField] private Rigidbody rb;
        public Rigidbody Rb => rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }
    }
}

