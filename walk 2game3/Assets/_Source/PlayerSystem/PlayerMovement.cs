using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(Rigidbody rb, float speed)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
        }

        public void Jump(Rigidbody rb, float jumpForce)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
