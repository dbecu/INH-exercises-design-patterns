namespace Assignment1
{
    partial class TrainDisplay
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
            this.lbl_CurrentStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CurrentStation
            // 
            this.lbl_CurrentStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CurrentStation.Location = new System.Drawing.Point(40, 23);
            this.lbl_CurrentStation.Name = "lbl_CurrentStation";
            this.lbl_CurrentStation.Size = new System.Drawing.Size(265, 88);
            this.lbl_CurrentStation.TabIndex = 0;
            this.lbl_CurrentStation.Text = "label1";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 145);
            this.Controls.Add(this.lbl_CurrentStation);
            this.Name = "TrainDisplay";
            this.Text = "Train Display";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CurrentStation;
    }
}