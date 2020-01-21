using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FunForCowBoy
{
    partial class Form1  
    {
        const int BUTTON_MARGIN = 50;
        private void restart()
        {
            orientation = false;
            clickCounterTextBox.Text = 0.ToString();
            clickCounter = 0;
            for (int i = 0; i < buttonDirection.Length; ++i)
            {
                buttonDirection[i] = (byte)Direction.BottomRight;
            }
            foreach (Button iter in buttons)
            {
                iter.BringToFront();
            }
            int _tmp = 0;
            foreach (Button iter in buttons)
            {
                iter.Location = new Point(ropeDefaultPosition.X + BUTTON_MARGIN * _tmp, ropeDefaultPosition.Y + BUTTON_MARGIN * _tmp++);
            }

        }
        //Счетчик кликоов
        int clickCounter = 0;
        //Массив кнопок
        Button[] buttons = new Button[12];
        // 
        bool orientation = false;
        enum Direction
        {
            BottomRight,
            BottomLeft,
            TopLeft,
            TopRight,
        }
        Button[] cows = new Button[7];
        private byte[] buttonDirection = new byte[12]
{
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight,
            (byte)Direction.BottomRight
};
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private Container components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.clickCounterTextBox = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1395, 743);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(300, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(250, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(200, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(150, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(100, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(50, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(100, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(750, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(800, 90);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(850, 140);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(900, 190);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(950, 240);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(1000, 290);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(1050, 340);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(1100, 390);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 60);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(1150, 440);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 60);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(1200, 490);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 60);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(1250, 540);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(1300, 590);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 60);
            this.button20.TabIndex = 19;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // clickCounterTextBox
            // 
            this.clickCounterTextBox.Location = new System.Drawing.Point(1155, 12);
            this.clickCounterTextBox.Name = "clickCounterTextBox";
            this.clickCounterTextBox.Size = new System.Drawing.Size(184, 20);
            this.clickCounterTextBox.TabIndex = 21;
            this.clickCounterTextBox.Text = "0";
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Location = new System.Drawing.Point(527, 581);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(338, 95);
            this.button21.TabIndex = 22;
            this.button21.Text = "Restart";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 768);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Location = new System.Drawing.Point(50, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 768);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Location = new System.Drawing.Point(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 768);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Location = new System.Drawing.Point(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 768);
            this.label4.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Location = new System.Drawing.Point(150, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 768);
            this.label5.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Location = new System.Drawing.Point(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 768);
            this.label6.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Location = new System.Drawing.Point(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 768);
            this.label7.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Location = new System.Drawing.Point(250, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 768);
            this.label8.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Location = new System.Drawing.Point(250, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 768);
            this.label9.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Location = new System.Drawing.Point(300, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 768);
            this.label10.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Location = new System.Drawing.Point(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 768);
            this.label11.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Location = new System.Drawing.Point(300, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 768);
            this.label12.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Location = new System.Drawing.Point(300, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 768);
            this.label13.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label14.Location = new System.Drawing.Point(350, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1, 768);
            this.label14.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label15.Location = new System.Drawing.Point(350, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 768);
            this.label15.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label16.Location = new System.Drawing.Point(350, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 768);
            this.label16.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label17.Location = new System.Drawing.Point(350, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1, 768);
            this.label17.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label18.Location = new System.Drawing.Point(400, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1, 768);
            this.label18.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label19.Location = new System.Drawing.Point(400, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1, 768);
            this.label19.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label20.Location = new System.Drawing.Point(400, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1, 768);
            this.label20.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label21.Location = new System.Drawing.Point(400, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1, 768);
            this.label21.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label22.Location = new System.Drawing.Point(450, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1, 768);
            this.label22.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label23.Location = new System.Drawing.Point(450, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1, 768);
            this.label23.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label24.Location = new System.Drawing.Point(450, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(1, 768);
            this.label24.TabIndex = 45;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label25.Location = new System.Drawing.Point(450, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(1, 768);
            this.label25.TabIndex = 44;
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label26.Location = new System.Drawing.Point(950, -13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(1, 768);
            this.label26.TabIndex = 72;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label27.Location = new System.Drawing.Point(950, -13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1, 768);
            this.label27.TabIndex = 71;
            // 
            // label28
            // 
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label28.Location = new System.Drawing.Point(950, -13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(1, 768);
            this.label28.TabIndex = 70;
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label29.Location = new System.Drawing.Point(950, -13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(1, 768);
            this.label29.TabIndex = 69;
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label30.Location = new System.Drawing.Point(900, -13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(1, 768);
            this.label30.TabIndex = 68;
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label31.Location = new System.Drawing.Point(900, -13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(1, 768);
            this.label31.TabIndex = 67;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label32.Location = new System.Drawing.Point(900, -13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1, 768);
            this.label32.TabIndex = 66;
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label33.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label33.Location = new System.Drawing.Point(900, -13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(1, 768);
            this.label33.TabIndex = 65;
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label34.Location = new System.Drawing.Point(850, -13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(1, 768);
            this.label34.TabIndex = 64;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label35.Location = new System.Drawing.Point(850, -13);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(1, 768);
            this.label35.TabIndex = 63;
            // 
            // label36
            // 
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label36.Location = new System.Drawing.Point(850, -13);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1, 768);
            this.label36.TabIndex = 62;
            // 
            // label37
            // 
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label37.Location = new System.Drawing.Point(850, -13);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1, 768);
            this.label37.TabIndex = 61;
            // 
            // label38
            // 
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label38.Location = new System.Drawing.Point(800, -13);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(1, 768);
            this.label38.TabIndex = 60;
            // 
            // label39
            // 
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label39.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label39.Location = new System.Drawing.Point(800, -13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(1, 768);
            this.label39.TabIndex = 59;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label40.Location = new System.Drawing.Point(800, -13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(1, 768);
            this.label40.TabIndex = 58;
            // 
            // label41
            // 
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label41.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label41.Location = new System.Drawing.Point(800, -13);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(1, 768);
            this.label41.TabIndex = 57;
            // 
            // label42
            // 
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label42.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label42.Location = new System.Drawing.Point(750, -13);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(1, 768);
            this.label42.TabIndex = 56;
            // 
            // label43
            // 
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label43.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label43.Location = new System.Drawing.Point(750, -13);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(1, 768);
            this.label43.TabIndex = 55;
            // 
            // label44
            // 
            this.label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label44.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label44.Location = new System.Drawing.Point(650, -13);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(1, 768);
            this.label44.TabIndex = 54;
            // 
            // label45
            // 
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label45.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label45.Location = new System.Drawing.Point(650, -13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(1, 768);
            this.label45.TabIndex = 53;
            // 
            // label46
            // 
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label46.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label46.Location = new System.Drawing.Point(0, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(1368, 1);
            this.label46.TabIndex = 52;
            // 
            // label47
            // 
            this.label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label47.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(1368, 1);
            this.label47.TabIndex = 51;
            // 
            // label48
            // 
            this.label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label48.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label48.Location = new System.Drawing.Point(600, -13);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(1, 768);
            this.label48.TabIndex = 50;
            // 
            // label49
            // 
            this.label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label49.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label49.Location = new System.Drawing.Point(550, -13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(1, 768);
            this.label49.TabIndex = 49;
            // 
            // label50
            // 
            this.label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label50.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label50.Location = new System.Drawing.Point(500, -13);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(1, 768);
            this.label50.TabIndex = 48;
            // 
            // label51
            // 
            this.label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label51.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label51.Location = new System.Drawing.Point(1400, -13);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(1, 768);
            this.label51.TabIndex = 97;
            // 
            // label52
            // 
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label52.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label52.Location = new System.Drawing.Point(1400, -13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(1, 768);
            this.label52.TabIndex = 96;
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label53.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label53.Location = new System.Drawing.Point(1400, -13);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(1, 768);
            this.label53.TabIndex = 95;
            // 
            // label54
            // 
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label54.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label54.Location = new System.Drawing.Point(1400, -13);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(1, 768);
            this.label54.TabIndex = 94;
            // 
            // label55
            // 
            this.label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label55.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label55.Location = new System.Drawing.Point(1350, -13);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(1, 768);
            this.label55.TabIndex = 93;
            // 
            // label56
            // 
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label56.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label56.Location = new System.Drawing.Point(1350, -13);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(1, 768);
            this.label56.TabIndex = 92;
            // 
            // label57
            // 
            this.label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label57.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label57.Location = new System.Drawing.Point(1350, -13);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(1, 768);
            this.label57.TabIndex = 91;
            // 
            // label58
            // 
            this.label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label58.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label58.Location = new System.Drawing.Point(1350, -13);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(1, 768);
            this.label58.TabIndex = 90;
            // 
            // label59
            // 
            this.label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label59.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label59.Location = new System.Drawing.Point(1300, -13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(1, 768);
            this.label59.TabIndex = 89;
            // 
            // label60
            // 
            this.label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label60.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label60.Location = new System.Drawing.Point(1300, -13);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(1, 768);
            this.label60.TabIndex = 88;
            // 
            // label61
            // 
            this.label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label61.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label61.Location = new System.Drawing.Point(1300, -13);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(1, 768);
            this.label61.TabIndex = 87;
            // 
            // label62
            // 
            this.label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label62.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label62.Location = new System.Drawing.Point(1300, -13);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(1, 768);
            this.label62.TabIndex = 86;
            // 
            // label63
            // 
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label63.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label63.Location = new System.Drawing.Point(1250, -13);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(1, 768);
            this.label63.TabIndex = 85;
            // 
            // label64
            // 
            this.label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label64.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label64.Location = new System.Drawing.Point(1250, -13);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(1, 768);
            this.label64.TabIndex = 84;
            // 
            // label65
            // 
            this.label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label65.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label65.Location = new System.Drawing.Point(1250, -13);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(1, 768);
            this.label65.TabIndex = 83;
            // 
            // label66
            // 
            this.label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label66.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label66.Location = new System.Drawing.Point(1250, -13);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(1, 768);
            this.label66.TabIndex = 82;
            // 
            // label67
            // 
            this.label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label67.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label67.Location = new System.Drawing.Point(1200, -13);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(1, 768);
            this.label67.TabIndex = 81;
            // 
            // label68
            // 
            this.label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label68.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label68.Location = new System.Drawing.Point(1200, -13);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(1, 768);
            this.label68.TabIndex = 80;
            // 
            // label69
            // 
            this.label69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label69.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label69.Location = new System.Drawing.Point(1150, -13);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(1, 768);
            this.label69.TabIndex = 79;
            // 
            // label70
            // 
            this.label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label70.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label70.Location = new System.Drawing.Point(1150, -13);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(1, 768);
            this.label70.TabIndex = 78;
            // 
            // label71
            // 
            this.label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label71.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label71.Location = new System.Drawing.Point(1100, -13);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(1, 768);
            this.label71.TabIndex = 77;
            // 
            // label72
            // 
            this.label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label72.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label72.Location = new System.Drawing.Point(1100, -13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(1, 768);
            this.label72.TabIndex = 76;
            // 
            // label73
            // 
            this.label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label73.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label73.Location = new System.Drawing.Point(1050, -13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(1, 768);
            this.label73.TabIndex = 75;
            // 
            // label74
            // 
            this.label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label74.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label74.Location = new System.Drawing.Point(1000, -13);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(1, 768);
            this.label74.TabIndex = 74;
            // 
            // label75
            // 
            this.label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label75.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label75.Location = new System.Drawing.Point(950, -13);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(1, 768);
            this.label75.TabIndex = 73;
            // 
            // label76
            // 
            this.label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label76.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label76.Location = new System.Drawing.Point(0, 50);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(1368, 1);
            this.label76.TabIndex = 99;
            // 
            // label77
            // 
            this.label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label77.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label77.Location = new System.Drawing.Point(0, 50);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(1368, 1);
            this.label77.TabIndex = 98;
            // 
            // label78
            // 
            this.label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label78.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label78.Location = new System.Drawing.Point(700, -13);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(1, 768);
            this.label78.TabIndex = 101;
            // 
            // label79
            // 
            this.label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label79.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label79.Location = new System.Drawing.Point(700, -13);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(1, 768);
            this.label79.TabIndex = 100;
            // 
            // label80
            // 
            this.label80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label80.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label80.Location = new System.Drawing.Point(15, 150);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(1368, 1);
            this.label80.TabIndex = 105;
            // 
            // label81
            // 
            this.label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label81.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label81.Location = new System.Drawing.Point(15, 150);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(1368, 1);
            this.label81.TabIndex = 104;
            // 
            // label82
            // 
            this.label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label82.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label82.Location = new System.Drawing.Point(15, 100);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(1368, 1);
            this.label82.TabIndex = 103;
            // 
            // label83
            // 
            this.label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label83.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label83.Location = new System.Drawing.Point(15, 100);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(1368, 1);
            this.label83.TabIndex = 102;
            // 
            // label84
            // 
            this.label84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label84.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label84.Location = new System.Drawing.Point(23, 350);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(1368, 1);
            this.label84.TabIndex = 113;
            // 
            // label85
            // 
            this.label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label85.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label85.Location = new System.Drawing.Point(23, 350);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(1368, 1);
            this.label85.TabIndex = 112;
            // 
            // label86
            // 
            this.label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label86.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label86.Location = new System.Drawing.Point(23, 300);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(1368, 1);
            this.label86.TabIndex = 111;
            // 
            // label87
            // 
            this.label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label87.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label87.Location = new System.Drawing.Point(23, 300);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(1368, 1);
            this.label87.TabIndex = 110;
            // 
            // label88
            // 
            this.label88.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label88.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label88.Location = new System.Drawing.Point(8, 250);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(1368, 1);
            this.label88.TabIndex = 109;
            // 
            // label89
            // 
            this.label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label89.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label89.Location = new System.Drawing.Point(8, 250);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(1368, 1);
            this.label89.TabIndex = 108;
            // 
            // label90
            // 
            this.label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label90.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label90.Location = new System.Drawing.Point(8, 200);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(1368, 1);
            this.label90.TabIndex = 107;
            // 
            // label91
            // 
            this.label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label91.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label91.Location = new System.Drawing.Point(8, 200);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(1368, 1);
            this.label91.TabIndex = 106;
            // 
            // label92
            // 
            this.label92.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label92.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label92.Location = new System.Drawing.Point(27, 700);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(1368, 1);
            this.label92.TabIndex = 127;
            // 
            // label93
            // 
            this.label93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label93.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label93.Location = new System.Drawing.Point(27, 700);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(1368, 1);
            this.label93.TabIndex = 126;
            // 
            // label94
            // 
            this.label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label94.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label94.Location = new System.Drawing.Point(27, 650);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(1368, 1);
            this.label94.TabIndex = 125;
            // 
            // label95
            // 
            this.label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label95.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label95.Location = new System.Drawing.Point(27, 650);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(1368, 1);
            this.label95.TabIndex = 124;
            // 
            // label96
            // 
            this.label96.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label96.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label96.Location = new System.Drawing.Point(12, 600);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(1368, 1);
            this.label96.TabIndex = 123;
            // 
            // label97
            // 
            this.label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label97.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label97.Location = new System.Drawing.Point(12, 600);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(1368, 1);
            this.label97.TabIndex = 122;
            // 
            // label98
            // 
            this.label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label98.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label98.Location = new System.Drawing.Point(12, 550);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(1368, 1);
            this.label98.TabIndex = 121;
            // 
            // label99
            // 
            this.label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label99.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label99.Location = new System.Drawing.Point(12, 550);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(1368, 1);
            this.label99.TabIndex = 120;
            // 
            // label100
            // 
            this.label100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label100.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label100.Location = new System.Drawing.Point(19, 500);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(1368, 1);
            this.label100.TabIndex = 119;
            // 
            // label101
            // 
            this.label101.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label101.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label101.Location = new System.Drawing.Point(19, 500);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(1368, 1);
            this.label101.TabIndex = 118;
            // 
            // label102
            // 
            this.label102.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label102.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label102.Location = new System.Drawing.Point(19, 400);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(1368, 1);
            this.label102.TabIndex = 117;
            // 
            // label103
            // 
            this.label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label103.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label103.Location = new System.Drawing.Point(19, 400);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(1368, 1);
            this.label103.TabIndex = 116;
            // 
            // label104
            // 
            this.label104.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label104.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label104.Location = new System.Drawing.Point(8, 450);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(1368, 1);
            this.label104.TabIndex = 115;
            // 
            // label105
            // 
            this.label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label105.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label105.Location = new System.Drawing.Point(8, 450);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(1368, 1);
            this.label105.TabIndex = 114;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 742);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.clickCounterTextBox);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox clickCounterTextBox;
        private Button button21;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label78;
        private Label label79;
        private Label label80;
        private Label label81;
        private Label label82;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label label87;
        private Label label88;
        private Label label89;
        private Label label90;
        private Label label91;
        private Label label92;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label label101;
        private Label label102;
        private Label label103;
        private Label label104;
        private Label label105;
    }
}

