namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {


        public enum Player
        {
            X,O
        }
        Player player1;
        Random random = new Random();
        int player_Wins = 0;
        int Computer_Wins = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            restart_game();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_CPU_Tick(object sender, EventArgs e)
        {
            if(buttons.Count>0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                player1 = Player.O;
                buttons[index].Text = player1.ToString();
              
               buttons[index].BackColor = Color.YellowGreen;
                buttons.RemoveAt(index);
                Game_Check();
                Timer_CPU.Stop();
            
            
            }
        }

        private void Player_Clicks_Button(object sender, EventArgs e)
        {
        
            var button = (Button)sender;
            player1 = Player.X;
            button.Text=player1.ToString(); 
            button.Enabled= false;
            button.BackColor = Color.Turquoise;
            buttons.Remove(button);
            Game_Check();
            Timer_CPU.Start();
        }

        private void Reset_Game(object sender, EventArgs e)
        {
            restart_game();
        }


        private void Game_Check()
        {
        
            if (button1.Text == "X" && button2.Text == "X" && button3.Text=="X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text=="X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                    )
            {

                Timer_CPU.Stop();
                MessageBox.Show("Player Wins");
                player_Wins++;
                label1.Text = "Player Wins :" + player_Wins;
                restart_game();
                   
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                Timer_CPU.Stop();
                MessageBox.Show("CPU Wins");
                Computer_Wins++;
                label2.Text += Computer_Wins;
                restart_game();

            }



                

        }

        private void restart_game()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        
        
        
        
        
        }
    }
}