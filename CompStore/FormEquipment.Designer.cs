
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
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboEqType = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.textSN = new System.Windows.Forms.TextBox();
            this.labelEqType = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textIN = new System.Windows.Forms.TextBox();
            this.labelIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBrand
            // 
            this.comboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(140, 39);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(232, 21);
            this.comboBrand.TabIndex = 1;
            this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.TypeOrBrandChange);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(45, 42);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(89, 13);
            this.labelBrand.TabIndex = 48;
            this.labelBrand.Text = "Производитель:";
            // 
            // comboEqType
            // 
            this.comboEqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEqType.FormattingEnabled = true;
            this.comboEqType.Location = new System.Drawing.Point(140, 12);
            this.comboEqType.Name = "comboEqType";
            this.comboEqType.Size = new System.Drawing.Size(232, 21);
            this.comboEqType.TabIndex = 0;
            this.comboEqType.SelectedIndexChanged += new System.EventHandler(this.TypeOrBrandChange);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(216, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
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
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(140, 145);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(232, 75);
            this.textCom.TabIndex = 5;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(61, 148);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 47;
            this.labelCom.Text = "Примечание:";
            // 
            // textSN
            // 
            this.textSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSN.Location = new System.Drawing.Point(140, 93);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(232, 20);
            this.textSN.TabIndex = 3;
            // 
            // labelEqType
            // 
            this.labelEqType.AutoSize = true;
            this.labelEqType.Location = new System.Drawing.Point(31, 15);
            this.labelEqType.Name = "labelEqType";
            this.labelEqType.Size = new System.Drawing.Size(103, 13);
            this.labelEqType.TabIndex = 46;
            this.labelEqType.Text = "Тип оборудования:";
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(38, 96);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(96, 13);
            this.labelSN.TabIndex = 45;
            this.labelSN.Text = "Серийный номер:";
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(140, 66);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(232, 21);
            this.comboModel.TabIndex = 2;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(85, 69);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 50;
            this.labelModel.Text = "Модель:";
            // 
            // textIN
            // 
            this.textIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIN.Location = new System.Drawing.Point(140, 119);
            this.textIN.Name = "textIN";
            this.textIN.Size = new System.Drawing.Size(232, 20);
            this.textIN.TabIndex = 4;
            // 
            // labelIN
            // 
            this.labelIN.AutoSize = true;
            this.labelIN.Location = new System.Drawing.Point(20, 122);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(114, 13);
            this.labelIN.TabIndex = 52;
            this.labelIN.Text = "Инвентарный номер:";
            // 
            // FormEquipment
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textIN);
            this.Controls.Add(this.labelIN);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.comboEqType);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.textSN);
            this.Controls.Add(this.labelEqType);
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

        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboEqType;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textSN;
        private System.Windows.Forms.Label labelEqType;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textIN;
        private System.Windows.Forms.Label labelIN;
    }
}