
namespace CompStore
{
    partial class FormRoom
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBuilding = new System.Windows.Forms.ComboBox();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(166, 126);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Записать";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(247, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(90, 65);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(232, 55);
            this.textCom.TabIndex = 3;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(11, 68);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 13;
            this.labelCom.Text = "Примечание:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(90, 39);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(232, 20);
            this.textName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Название:";
            // 
            // comboBuilding
            // 
            this.comboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuilding.FormattingEnabled = true;
            this.comboBuilding.Location = new System.Drawing.Point(90, 12);
            this.comboBuilding.Name = "comboBuilding";
            this.comboBuilding.Size = new System.Drawing.Size(232, 21);
            this.comboBuilding.TabIndex = 1;
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(37, 15);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(47, 13);
            this.labelBuilding.TabIndex = 18;
            this.labelBuilding.Text = "Здание:";
            // 
            // FormRoom
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.comboBuilding);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBuilding;
        private System.Windows.Forms.Label labelBuilding;
    }
}