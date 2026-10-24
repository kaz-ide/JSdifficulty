namespace JSdifficulty
{
    partial class frmMAIN
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
            gbDandD = new GroupBox();
            btnCLOSE = new Button();
            SuspendLayout();
            // 
            // gbDandD
            // 
            gbDandD.Location = new Point(12, 12);
            gbDandD.Name = "gbDandD";
            gbDandD.Size = new Size(519, 251);
            gbDandD.TabIndex = 0;
            gbDandD.TabStop = false;
            gbDandD.Text = "ここにJavaScriptの入ったソースファイルをD&Dしてください";
            gbDandD.DragDrop += gbDandD_DragDrop;
            // 
            // btnCLOSE
            // 
            btnCLOSE.Location = new Point(373, 309);
            btnCLOSE.Name = "btnCLOSE";
            btnCLOSE.Size = new Size(158, 45);
            btnCLOSE.TabIndex = 1;
            btnCLOSE.Text = "閉じる";
            btnCLOSE.UseVisualStyleBackColor = true;
            btnCLOSE.Click += btnCLOSE_Click;
            // 
            // frmMAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 365);
            Controls.Add(btnCLOSE);
            Controls.Add(gbDandD);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JavaScript難読化";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDandD;
        private Button btnCLOSE;
    }
}
