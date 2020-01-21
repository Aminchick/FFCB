using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FunForCowBoy
{
    public partial class Form1 : Form
    {
        public Point ropeDefaultPosition = new Point(750, 40);

        public Point cowDefaultPosition = new Point(300,90);
        public Form1()
        {
            InitializeComponent();
        }
        private byte SwitchButtonState(byte currentState,Color bColor) 
        {
            if(bColor == Color.FromArgb(255, 128, 0))
            {
                if(currentState == 0)
                {
                    return (byte)Direction.BottomLeft;
                }
                if(currentState == 1) 
                {
                    return (byte)Direction.TopLeft;
                }
                if(currentState == 2)
                {
                    return (byte)Direction.TopRight;
                }
                if(currentState == 3)
                {
                    return (byte)Direction.BottomRight;
                }
            }
            else if(bColor == Color.FromArgb(192, 192, 0))
            {
                if (currentState == 0)
                {
                    return (byte)Direction.TopRight;
                }
                if (currentState == 1)
                {
                    return (byte)Direction.BottomRight;
                }
                if (currentState == 2)
                {
                    return (byte)Direction.BottomLeft;
                }
                if (currentState == 3)
                {
                    return (byte)Direction.TopLeft;
                }
            }
            return 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttons[0] =  button9;
            buttons[1] =  button10;
            buttons[2] =  button11;
            buttons[3] =  button12;
            buttons[4] =  button13;
            buttons[5] =  button14;
            buttons[6] =  button15;
            buttons[7] =  button16;
            buttons[8] =  button17;
            buttons[9] =  button18;
            buttons[10] = button19;
            buttons[11] = button20;

            cows[0] = button2;
            cows[1] = button3;
            cows[2] = button4;
            cows[3] = button5;
            cows[4] = button6;
            cows[5] = button7;
            cows[6] = button8;

            cows[0].Location = cowDefaultPosition;
            
            cows[1].Location = new Point(cowDefaultPosition.X, cowDefaultPosition.Y);
           
            cows[2].Location = new Point(cows[1].Location.X - BUTTON_MARGIN, cows[1].Location.Y + BUTTON_MARGIN);

            cows[3].Location = new Point(cows[2].Location.X - BUTTON_MARGIN, cows[2].Location.Y + BUTTON_MARGIN);

            cows[4].Location = new Point(cows[3].Location.X + BUTTON_MARGIN, cows[3].Location.Y + BUTTON_MARGIN);

            cows[5].Location = new Point(cows[4].Location.X + BUTTON_MARGIN, cows[4].Location.Y - BUTTON_MARGIN);

            cows[6].Location = new Point(cows[5].Location.X + BUTTON_MARGIN, cows[5].Location.Y + BUTTON_MARGIN);

            foreach (Button iter in buttons)
            {
                iter.Click += new System.EventHandler(button_click);
                iter.BringToFront();
            }
            orientation = false;
        }
        private void button_click(object sender, EventArgs e)
        {
            int FINAL_MARGIN=0;
            ++clickCounter;
            int moveDirection = 0;
            clickCounterTextBox.Text = clickCounter.ToString();
            int senderIndex = -1;
            // Находим индекс сендера
            for (int i = 0 ; i < buttons.Length;++i)
            {
                if (buttons[i] == sender)
                    senderIndex = i;
            }

            if(buttons[senderIndex].BackColor == Color.FromArgb(255,128,0))
             {
                moveDirection = 1;
             }
             else
             {
                moveDirection = -1;
             }
            FINAL_MARGIN = moveDirection * BUTTON_MARGIN*(orientation ? -1 : 1) ;
            if (!orientation)
            { 
                for(int i =  senderIndex + 1 ; i < buttons.Length ; i++ )
                { 
                    switch(buttonDirection[Array.IndexOf(buttons,buttons[i])-1])
                    {
                        //Direction.BottomRight
                        case 0:
                        {
                            buttons[i].Location = new Point(buttons[i - 1].Location.X - FINAL_MARGIN,
                                                            buttons[i - 1].Location.Y + FINAL_MARGIN);
                            break;
                        }
                        //Direction.BottomLeft
                        case 1:
                        {
                            buttons[i].Location = new Point(buttons[i - 1].Location.X - FINAL_MARGIN,
                                                            buttons[i - 1].Location.Y - FINAL_MARGIN);
                            break;
                        }
                        //Direction.TopLeft
                        case 2:
                        {
                            buttons[i].Location = new Point(buttons[i - 1].Location.X + FINAL_MARGIN,
                                                            buttons[i - 1].Location.Y - FINAL_MARGIN);
                            break;
                        }
                        //Direction.TopRight
                        case 3:
                        {
                            buttons[i].Location = new Point(buttons[i - 1].Location.X + FINAL_MARGIN,
                                                            buttons[i - 1].Location.Y  + FINAL_MARGIN);
                            break;
                        }
                    }
                    buttonDirection[Array.IndexOf(buttons, buttons[i]) - 1] = this.SwitchButtonState(buttonDirection[Array.IndexOf(buttons, buttons[i]) - 1],
                                                                                                     buttons[senderIndex].BackColor);
                }
            }
            else
            {
                for(int i =  senderIndex - 1 ; i >= 0 ; i-- )
                {
                    switch (buttonDirection[Array.IndexOf(buttons, buttons[i])])
                    {
                        case 0:
                        {
                            buttons[i].Location = new Point(buttons[i + 1].Location.X - FINAL_MARGIN,
                                                            buttons[i + 1].Location.Y + FINAL_MARGIN);
                            break;
                        }
                        case  1:
                        {
                            buttons[i].Location = new Point(buttons[i + 1].Location.X - FINAL_MARGIN,
                                                            buttons[i + 1].Location.Y - FINAL_MARGIN);
                            break;
                        }
                        case 2:
                        {
                            buttons[i].Location = new Point(buttons[i + 1].Location.X + FINAL_MARGIN,
                                                            buttons[i + 1].Location.Y - FINAL_MARGIN);
                            break;
                        }
                        case 3:
                        {
                            buttons[i].Location = new Point(buttons[i + 1].Location.X + FINAL_MARGIN,
                                                            buttons[i + 1].Location.Y  + FINAL_MARGIN);
                            break;
                        }

                    }
                    buttonDirection[Array.IndexOf(buttons, buttons[i]) ] = this.SwitchButtonState(buttonDirection[Array.IndexOf(buttons, buttons[i])],
                                                                                                  buttons[senderIndex].BackColor);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        if(!orientation)
            for(int i = buttons.Length - 1 ; i >= 0;--i)
            {
                buttons[i].BringToFront();
            }
        else 
           for(int i = 0 ; i < buttons.Length ; ++i)
            {
                buttons[i].BringToFront();
            }
        orientation = !orientation;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.restart();
        }
    }
}
