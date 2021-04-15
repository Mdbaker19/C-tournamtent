
namespace TrackerUI
{
    partial class CreatePrize
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
            this.placenumberlabel = new System.Windows.Forms.Label();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.prizeamountLabel = new System.Windows.Forms.Label();
            this.percentPrizeLabel = new System.Windows.Forms.Label();
            this.prizePlacenumbervalue = new System.Windows.Forms.TextBox();
            this.prizeplacenamevalue = new System.Windows.Forms.TextBox();
            this.prizeamountValue = new System.Windows.Forms.TextBox();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placenumberlabel
            // 
            this.placenumberlabel.AutoSize = true;
            this.placenumberlabel.Location = new System.Drawing.Point(54, 24);
            this.placenumberlabel.Name = "placenumberlabel";
            this.placenumberlabel.Size = new System.Drawing.Size(108, 21);
            this.placenumberlabel.TabIndex = 0;
            this.placenumberlabel.Text = "Place Number";
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Location = new System.Drawing.Point(54, 80);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(92, 21);
            this.PlaceNameLabel.TabIndex = 1;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // prizeamountLabel
            // 
            this.prizeamountLabel.AutoSize = true;
            this.prizeamountLabel.Location = new System.Drawing.Point(54, 139);
            this.prizeamountLabel.Name = "prizeamountLabel";
            this.prizeamountLabel.Size = new System.Drawing.Size(104, 21);
            this.prizeamountLabel.TabIndex = 2;
            this.prizeamountLabel.Text = "Prize Amount";
            // 
            // percentPrizeLabel
            // 
            this.percentPrizeLabel.AutoSize = true;
            this.percentPrizeLabel.Location = new System.Drawing.Point(12, 194);
            this.percentPrizeLabel.Name = "percentPrizeLabel";
            this.percentPrizeLabel.Size = new System.Drawing.Size(124, 21);
            this.percentPrizeLabel.TabIndex = 3;
            this.percentPrizeLabel.Text = "Prize Percentage";
            // 
            // prizePlacenumbervalue
            // 
            this.prizePlacenumbervalue.Location = new System.Drawing.Point(162, 21);
            this.prizePlacenumbervalue.Name = "prizePlacenumbervalue";
            this.prizePlacenumbervalue.Size = new System.Drawing.Size(100, 29);
            this.prizePlacenumbervalue.TabIndex = 4;
            // 
            // prizeplacenamevalue
            // 
            this.prizeplacenamevalue.Location = new System.Drawing.Point(162, 77);
            this.prizeplacenamevalue.Name = "prizeplacenamevalue";
            this.prizeplacenamevalue.Size = new System.Drawing.Size(100, 29);
            this.prizeplacenamevalue.TabIndex = 5;
            // 
            // prizeamountValue
            // 
            this.prizeamountValue.Location = new System.Drawing.Point(162, 136);
            this.prizeamountValue.Name = "prizeamountValue";
            this.prizeamountValue.Size = new System.Drawing.Size(100, 29);
            this.prizeamountValue.TabIndex = 6;
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(162, 186);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(100, 29);
            this.prizePercentageValue.TabIndex = 7;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(76, 253);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(174, 73);
            this.createPrizeButton.TabIndex = 8;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // orlabel
            // 
            this.orlabel.AutoSize = true;
            this.orlabel.Location = new System.Drawing.Point(294, 168);
            this.orlabel.Name = "orlabel";
            this.orlabel.Size = new System.Drawing.Size(28, 21);
            this.orlabel.TabIndex = 9;
            this.orlabel.Text = "Or";
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(412, 447);
            this.Controls.Add(this.orlabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizeamountValue);
            this.Controls.Add(this.prizeplacenamevalue);
            this.Controls.Add(this.prizePlacenumbervalue);
            this.Controls.Add(this.percentPrizeLabel);
            this.Controls.Add(this.prizeamountLabel);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.placenumberlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreatePrize";
            this.Text = "CreatePrize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placenumberlabel;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.Label prizeamountLabel;
        private System.Windows.Forms.Label percentPrizeLabel;
        private System.Windows.Forms.TextBox prizePlacenumbervalue;
        private System.Windows.Forms.TextBox prizeplacenamevalue;
        private System.Windows.Forms.TextBox prizeamountValue;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label orlabel;
    }
}