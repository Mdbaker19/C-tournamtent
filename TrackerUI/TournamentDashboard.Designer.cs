
namespace TrackerUI
{
    partial class TournamentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournDashLabel = new System.Windows.Forms.Label();
            this.tournamentToLoadDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournLabel = new System.Windows.Forms.Label();
            this.LoadATournBtn = new System.Windows.Forms.Button();
            this.CreateTournBtnDashBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournDashLabel
            // 
            this.tournDashLabel.AutoSize = true;
            this.tournDashLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournDashLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tournDashLabel.Location = new System.Drawing.Point(270, 19);
            this.tournDashLabel.Name = "tournDashLabel";
            this.tournDashLabel.Size = new System.Drawing.Size(240, 30);
            this.tournDashLabel.TabIndex = 0;
            this.tournDashLabel.Text = "Tournament DashBoard";
            // 
            // tournamentToLoadDropDown
            // 
            this.tournamentToLoadDropDown.FormattingEnabled = true;
            this.tournamentToLoadDropDown.Location = new System.Drawing.Point(251, 112);
            this.tournamentToLoadDropDown.Name = "tournamentToLoadDropDown";
            this.tournamentToLoadDropDown.Size = new System.Drawing.Size(289, 29);
            this.tournamentToLoadDropDown.TabIndex = 1;
            // 
            // loadTournLabel
            // 
            this.loadTournLabel.AutoSize = true;
            this.loadTournLabel.Location = new System.Drawing.Point(299, 67);
            this.loadTournLabel.Name = "loadTournLabel";
            this.loadTournLabel.Size = new System.Drawing.Size(188, 21);
            this.loadTournLabel.TabIndex = 2;
            this.loadTournLabel.Text = "Load Existing Tournament";
            // 
            // LoadATournBtn
            // 
            this.LoadATournBtn.Location = new System.Drawing.Point(318, 157);
            this.LoadATournBtn.Name = "LoadATournBtn";
            this.LoadATournBtn.Size = new System.Drawing.Size(153, 52);
            this.LoadATournBtn.TabIndex = 3;
            this.LoadATournBtn.Text = "Load Tournament";
            this.LoadATournBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournBtnDashBoard
            // 
            this.CreateTournBtnDashBoard.Location = new System.Drawing.Point(318, 277);
            this.CreateTournBtnDashBoard.Name = "CreateTournBtnDashBoard";
            this.CreateTournBtnDashBoard.Size = new System.Drawing.Size(153, 62);
            this.CreateTournBtnDashBoard.TabIndex = 4;
            this.CreateTournBtnDashBoard.Text = "Create Tournament";
            this.CreateTournBtnDashBoard.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateTournBtnDashBoard);
            this.Controls.Add(this.LoadATournBtn);
            this.Controls.Add(this.loadTournLabel);
            this.Controls.Add(this.tournamentToLoadDropDown);
            this.Controls.Add(this.tournDashLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournDashLabel;
        private System.Windows.Forms.ComboBox tournamentToLoadDropDown;
        private System.Windows.Forms.Label loadTournLabel;
        private System.Windows.Forms.Button LoadATournBtn;
        private System.Windows.Forms.Button CreateTournBtnDashBoard;
    }
}