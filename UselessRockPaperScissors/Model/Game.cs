using System.Windows.Forms;

namespace UselessRockPaperScissors.Model
{
    public class Game
    {

        public static void Start(Weapon weapon)
        {
            string cpuWeapon = "";

            switch (weapon)
            {
                case Weapon.Rock:
                    cpuWeapon = "Paper";
                    break;
                
                case Weapon.Paper:
                    cpuWeapon = "Scissors";
                    break;
                
                case Weapon.Scissors:
                    cpuWeapon = "Rock";
                    break;
            }
            
            MessageBox.Show("The computer choose " + cpuWeapon + ", you lose!", "You lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}