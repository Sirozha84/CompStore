namespace CompStore
{
    partial class FormProperties
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
            this.groupCompany = new System.Windows.Forms.GroupBox();
            this.labelCompInfo = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.textComp = new System.Windows.Forms.TextBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.textDep = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLastUCN = new System.Windows.Forms.Label();
            this.textLastUCN = new System.Windows.Forms.TextBox();
            this.groupCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCompany
            // 
            this.groupCompany.Controls.Add(this.labelCompInfo);
            this.groupCompany.Controls.Add(this.labelComp);
            this.groupCompany.Controls.Add(this.textComp);
            this.groupCompany.Controls.Add(this.labelDep);
            this.groupCompany.Controls.Add(this.textDep);
            this.groupCompany.Location = new System.Drawing.Point(12, 12);
            this.groupCompany.Name = "groupCompany";
            this.groupCompany.Size = new System.Drawing.Size(332, 105);
            this.groupCompany.TabIndex = 0;
            this.groupCompany.TabStop = false;
            this.groupCompany.Text = "Данные об организации";
            // 
            // labelCompInfo
            // 
            this.labelCompInfo.AutoSize = true;
            this.labelCompInfo.Location = new System.Drawing.Point(7, 20);
            this.labelCompInfo.Name = "labelCompInfo";
            this.labelCompInfo.Size = new System.Drawing.Size(237, 13);
            this.labelCompInfo.TabIndex = 0;
            this.labelCompInfo.Text = "Эти сведения будут печататься в документах";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(25, 49);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(77, 13);
            this.labelComp.TabIndex = 1;
            this.labelComp.Text = "Организация:";
            // 
            // textComp
            // 
            this.textComp.Location = new System.Drawing.Point(108, 46);
            this.textComp.Name = "textComp";
            this.textComp.Size = new System.Drawing.Size(218, 20);
            this.textComp.TabIndex = 0;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(12, 75);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(90, 13);
            this.labelDep.TabIndex = 3;
            this.labelDep.Text = "Подразделение:";
            // 
            // textDep
            // 
            this.textDep.Location = new System.Drawing.Point(108, 72);
            this.textDep.Name = "textDep";
            this.textDep.Size = new System.Drawing.Size(218, 20);
            this.textDep.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(189, 160);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(270, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelLastUCN
            // 
            this.labelLastUCN.AutoSize = true;
            this.labelLastUCN.Location = new System.Drawing.Point(24, 126);
            this.labelLastUCN.Name = "labelLastUCN";
            this.labelLastUCN.Size = new System.Drawing.Size(169, 13);
            this.labelLastUCN.TabIndex = 5;
            this.labelLastUCN.Text = "Текущий номер карточки учёта:";
            // 
            // textLastUCN
            // 
            this.textLastUCN.Location = new System.Drawing.Point(199, 123);
            this.textLastUCN.Name = "textLastUCN";
            this.textLastUCN.Size = new System.Drawing.Size(139, 20);
            this.textLastUCN.TabIndex = 2;
            // 
            // FormProperties
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(357, 195);
            this.Controls.Add(this.groupCompany);
            this.Controls.Add(this.labelLastUCN);
            this.Controls.Add(this.textLastUCN);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.groupCompany.ResumeLayout(false);
            this.groupCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCompany;
        private System.Windows.Forms.Label labelCompInfo;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox textComp;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.TextBox textDep;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLastUCN;
        private System.Windows.Forms.TextBox textLastUCN;
    }
}