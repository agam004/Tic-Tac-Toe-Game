namespace _4Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            playerLabel = new Label();
            winnerList = new ListBox();
            label2 = new Label();
            button2 = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 50);
            label1.Name = "label1";
            label1.Size = new Size(299, 60);
            label1.TabIndex = 1;
            label1.Text = "TIC TAC TOE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox9, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox8, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox7, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox6, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Location = new Point(109, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(575, 396);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox9
            // 
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Location = new Point(386, 268);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(181, 122);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "9";
            pictureBox9.Click += BoxClicked;
            // 
            // pictureBox8
            // 
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Location = new Point(196, 268);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(181, 122);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "8";
            pictureBox8.Click += BoxClicked;
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Location = new Point(6, 268);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(181, 122);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "7";
            pictureBox7.Click += BoxClicked;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Location = new Point(386, 137);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(181, 122);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "6";
            pictureBox6.Click += BoxClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Location = new Point(196, 137);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(181, 122);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "5";
            pictureBox5.Click += BoxClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(6, 137);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(181, 122);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "4";
            pictureBox4.Click += BoxClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(196, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "2";
            pictureBox2.Click += BoxClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "1";
            pictureBox1.Click += BoxClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(386, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(181, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "3";
            pictureBox3.Click += BoxClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(867, 602);
            button1.Name = "button1";
            button1.Size = new Size(207, 60);
            button1.TabIndex = 3;
            button1.Text = "Reset Board";
            toolTip1.SetToolTip(button1, "Clear board to restart Game (Does not Clear Leader Board");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.BackColor = SystemColors.Window;
            playerLabel.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerLabel.Location = new Point(125, 602);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(433, 60);
            playerLabel.TabIndex = 4;
            playerLabel.Text = "current Player";
            toolTip2.SetToolTip(playerLabel, "Player with Turn Right Now");
            // 
            // winnerList
            // 
            winnerList.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winnerList.FormattingEnabled = true;
            winnerList.ItemHeight = 30;
            winnerList.Location = new Point(792, 156);
            winnerList.Name = "winnerList";
            winnerList.Size = new Size(295, 394);
            winnerList.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(801, 91);
            label2.Name = "label2";
            label2.Size = new Size(273, 44);
            label2.TabIndex = 6;
            label2.Text = "leaderboard";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(683, 602);
            button2.Name = "button2";
            button2.Size = new Size(162, 60);
            button2.TabIndex = 7;
            button2.Text = "Quit Game";
            toolTip3.SetToolTip(button2, "Exit The Game and Reset Leaderboard.\r\n");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1129, 745);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(winnerList);
            Controls.Add(playerLabel);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            toolTip2.SetToolTip(this, "Player Playing Right Now");
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button1;
        private Label playerLabel;
        private ListBox winnerList;
        private Label label2;
        private Button button2;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
    }
}
