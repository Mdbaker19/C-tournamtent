
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameInput = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.selecteTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteTeamMemberBtn = new System.Windows.Forms.Button();
            this.CreateTeamBtn = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameInput
            // 
            this.teamNameInput.Location = new System.Drawing.Point(12, 105);
            this.teamNameInput.Name = "teamNameInput";
            this.teamNameInput.Size = new System.Drawing.Size(142, 32);
            this.teamNameInput.TabIndex = 8;
            this.teamNameInput.TextChanged += new System.EventHandler(this.tournamentNameInput_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 77);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(62, 25);
            this.teamNameLabel.TabIndex = 7;
            this.teamNameLabel.Text = "Name";
            this.teamNameLabel.Click += new System.EventHandler(this.tournamentNameLabel_Click);
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.createTeamLabel.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.Location = new System.Drawing.Point(12, 27);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(131, 36);
            this.createTeamLabel.TabIndex = 6;
            this.createTeamLabel.Text = "Create Team";
            this.createTeamLabel.Click += new System.EventHandler(this.headerLabelCreate_Click);
            // 
            // selecteTeamMemberLabel
            // 
            this.selecteTeamMemberLabel.AutoSize = true;
            this.selecteTeamMemberLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.selecteTeamMemberLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.selecteTeamMemberLabel.Location = new System.Drawing.Point(12, 151);
            this.selecteTeamMemberLabel.Name = "selecteTeamMemberLabel";
            this.selecteTeamMemberLabel.Size = new System.Drawing.Size(182, 25);
            this.selecteTeamMemberLabel.TabIndex = 9;
            this.selecteTeamMemberLabel.Text = "select team member";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(203, 99);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(139, 38);
            this.addMemberBtn.TabIndex = 11;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(200, 148);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(142, 33);
            this.selectTeamMemberComboBox.TabIndex = 12;
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.createMemberBtn);
            this.AddNewMemberBox.Controls.Add(this.cellPhoneValue);
            this.AddNewMemberBox.Controls.Add(this.cellPhoneLabel);
            this.AddNewMemberBox.Controls.Add(this.emailValue);
            this.AddNewMemberBox.Controls.Add(this.emailLabel);
            this.AddNewMemberBox.Controls.Add(this.lastNameValue);
            this.AddNewMemberBox.Controls.Add(this.lastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.firstNameValue);
            this.AddNewMemberBox.Controls.Add(this.firstNameLabel);
            this.AddNewMemberBox.Location = new System.Drawing.Point(12, 197);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(330, 241);
            this.AddNewMemberBox.TabIndex = 13;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(131, 31);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(149, 32);
            this.firstNameValue.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 25);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(131, 73);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(149, 32);
            this.lastNameValue.TabIndex = 17;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 25);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(131, 116);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(149, 32);
            this.emailValue.TabIndex = 19;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(11, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 25);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email";
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(131, 166);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(149, 32);
            this.cellPhoneValue.TabIndex = 21;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cellPhoneLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cellPhoneLabel.Location = new System.Drawing.Point(11, 169);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(60, 25);
            this.cellPhoneLabel.TabIndex = 20;
            this.cellPhoneLabel.Text = "Cell #";
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.Location = new System.Drawing.Point(21, 203);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(235, 38);
            this.createMemberBtn.TabIndex = 14;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 25;
            this.TeamMembersListBox.Location = new System.Drawing.Point(370, 84);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(232, 354);
            this.TeamMembersListBox.TabIndex = 14;
            // 
            // deleteTeamMemberBtn
            // 
            this.deleteTeamMemberBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTeamMemberBtn.Location = new System.Drawing.Point(384, 27);
            this.deleteTeamMemberBtn.Name = "deleteTeamMemberBtn";
            this.deleteTeamMemberBtn.Size = new System.Drawing.Size(218, 51);
            this.deleteTeamMemberBtn.TabIndex = 15;
            this.deleteTeamMemberBtn.Text = "Delete Selected Member";
            this.deleteTeamMemberBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamBtn
            // 
            this.CreateTeamBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamBtn.Location = new System.Drawing.Point(164, 444);
            this.CreateTeamBtn.Name = "CreateTeamBtn";
            this.CreateTeamBtn.Size = new System.Drawing.Size(251, 32);
            this.CreateTeamBtn.TabIndex = 16;
            this.CreateTeamBtn.Text = "Create Team";
            this.CreateTeamBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 478);
            this.Controls.Add(this.CreateTeamBtn);
            this.Controls.Add(this.deleteTeamMemberBtn);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.selecteTeamMemberLabel);
            this.Controls.Add(this.teamNameInput);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameInput;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label selecteTeamMemberLabel;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.Button createMemberBtn;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button deleteTeamMemberBtn;
        private System.Windows.Forms.Button CreateTeamBtn;
    }
}