namespace Tic_Tac_Toe
{
    partial class TicTacToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 83);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(90, 90);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(204, 83);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(90, 90);
            this.A3.TabIndex = 1;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(108, 83);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(90, 90);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(108, 179);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 90);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(204, 179);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 90);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 179);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 90);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(108, 275);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(90, 90);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(204, 275);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(90, 90);
            this.C3.TabIndex = 7;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(12, 275);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(90, 90);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinnerLabel.Location = new System.Drawing.Point(9, 383);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(0, 28);
            this.WinnerLabel.TabIndex = 9;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(220, 390);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 10;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.newGame_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button A1;
        private Button A3;
        private Button A2;
        private Button B2;
        private Button B3;
        private Button B1;
        private Button C2;
        private Button C3;
        private Button C1;
        private Label WinnerLabel;
        private Button NewGameButton;
    }
}