﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i=0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j=0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };

                    pnlChessBoard.Controls.Add(btn);

                    oldButton = btn;                   
                }

                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
    }
}
