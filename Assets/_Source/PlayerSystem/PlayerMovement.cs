using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(float xMove, Player player)
        {
            player.Rb.velocity = new Vector2(xMove * player.MoveSpeed, player.Rb.velocity.y);
        }
        public void Jump(Player player)
        {
            player.Rb.AddForce(Vector2.up * player.JumpForce);
        }
    }
}