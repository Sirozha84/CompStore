
namespace CompStore
{
    partial class FormEquipment
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
            this.textSN = new System.Windows.Forms.TextBox();
            this.labelSN = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textIN = new System.Windows.Forms.TextBox();
            this.labelIN = new System.Windows.Forms.Label();
            this.labelBuyDate = new System.Windows.Forms.Label();
            this.dateBuy = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(216, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "Записать";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(140, 117);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(232, 103);
            this.textCom.TabIndex = 6;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(61, 120);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 47;
            this.labelCom.Text = "Примечание:";
            // 
            // textSN
            // 
            this.textSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSN.Location = new System.Drawing.Point(140, 39);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(232, 20);
            this.textSN.TabIndex = 3;
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(38, 42);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(96, 13);
            this.labelSN.TabIndex = 45;
            this.labelSN.Text = "Серийный номер:";
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(140, 12);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(232, 21);
            this.comboModel.TabIndex = 2;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(85, 15);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 50;
            this.labelModel.Text = "Модель:";
            // 
            // textIN
            // 
            this.textIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIN.Location = new System.Drawing.Point(140, 65);
            this.textIN.Name = "textIN";
            this.textIN.Size = new System.Drawing.Size(232, 20);
            this.textIN.TabIndex = 4;
            // 
            // labelIN
            // 
            this.labelIN.AutoSize = true;
            this.labelIN.Location = new System.Drawing.Point(20, 68);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(114, 13);
            this.labelIN.TabIndex = 52;
            this.labelIN.Text = "Инвентарный номер:";
            // 
            // labelBuyDate
            // 
            this.labelBuyDate.AutoSize = true;
            this.labelBuyDate.Location = new System.Drawing.Point(54, 94);
            this.labelBuyDate.Name = "labelBuyDate";
            this.labelBuyDate.Size = new System.Drawing.Size(80, 13);
            this.labelBuyDate.TabIndex = 74;
            this.labelBuyDate.Text = "Дата покупки:";
            // 
            // dateBuy
            // 
            this.dateBuy.Location = new System.Drawing.Point(140, 91);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.ShowCheckBox = true;
            this.dateBuy.Size = new System.Drawing.Size(157, 20);
            this.dateBuy.TabIndex = 5;
            // 
            // FormEquipment
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelBuyDate);
            this.Controls.Add(this.dateBuy);
            this.Controls.Add(this.textIN);
            this.Controls.Add(this.labelIN);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.textSN);
            this.Controls.Add(this.labelSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipment";
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
        private System.Windows.Forms.TextBox textSN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textIN;
        private System.Windows.Forms.Label labelIN;
        private System.Windows.Forms.Label labelBuyDate;
        private System.Windows.Forms.DateTimePicker dateBuy;
    }
}