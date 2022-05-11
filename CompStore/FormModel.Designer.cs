
namespace CompStore
{
    partial class FormModel
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
            this.components = new System.ComponentModel.Container();
            this.combovendor = new System.Windows.Forms.ComboBox();
            this.labelvendor = new System.Windows.Forms.Label();
            this.comboEqType = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelEqType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonTEAdd = new System.Windows.Forms.Button();
            this.buttonvendorAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combovendor
            // 
            this.combovendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combovendor.FormattingEnabled = true;
            this.combovendor.Location = new System.Drawing.Point(120, 39);
            this.combovendor.Name = "combovendor";
            this.combovendor.Size = new System.Drawing.Size(205, 21);
            this.combovendor.TabIndex = 1;
            this.combovendor.SelectedIndexChanged += new System.EventHandler(this.CheckField);
            // 
            // labelvendor
            // 
            this.labelvendor.AutoSize = true;
            this.labelvendor.Location = new System.Drawing.Point(25, 42);
            this.labelvendor.Name = "labelvendor";
            this.labelvendor.Size = new System.Drawing.Size(89, 13);
            this.labelvendor.TabIndex = 38;
            this.labelvendor.Text = "Производитель:";
            // 
            // comboEqType
            // 
            this.comboEqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEqType.FormattingEnabled = true;
            this.comboEqType.Location = new System.Drawing.Point(120, 12);
            this.comboEqType.Name = "comboEqType";
            this.comboEqType.Size = new System.Drawing.Size(205, 21);
            this.comboEqType.TabIndex = 0;
            this.comboEqType.SelectedIndexChanged += new System.EventHandler(this.CheckField);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(196, 146);
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
            this.buttonCancel.Location = new System.Drawing.Point(277, 146);
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
            this.textCom.Location = new System.Drawing.Point(120, 92);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(232, 48);
            this.textCom.TabIndex = 3;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(41, 95);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 33;
            this.labelCom.Text = "Примечание:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(120, 66);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(232, 20);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.CheckField);
            // 
            // labelEqType
            // 
            this.labelEqType.AutoSize = true;
            this.labelEqType.Location = new System.Drawing.Point(11, 15);
            this.labelEqType.Name = "labelEqType";
            this.labelEqType.Size = new System.Drawing.Size(103, 13);
            this.labelEqType.TabIndex = 31;
            this.labelEqType.Text = "Тип оборудования:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(54, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Название:";
            // 
            // buttonTEAdd
            // 
            this.buttonTEAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTEAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonTEAdd.Location = new System.Drawing.Point(331, 11);
            this.buttonTEAdd.Name = "buttonTEAdd";
            this.buttonTEAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonTEAdd.TabIndex = 92;
            this.buttonTEAdd.UseVisualStyleBackColor = true;
            this.buttonTEAdd.Click += new System.EventHandler(this.EquipmentTypeAdd);
            // 
            // buttonvendorAdd
            // 
            this.buttonvendorAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvendorAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonvendorAdd.Location = new System.Drawing.Point(331, 38);
            this.buttonvendorAdd.Name = "buttonvendorAdd";
            this.buttonvendorAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonvendorAdd.TabIndex = 93;
            this.buttonvendorAdd.UseVisualStyleBackColor = true;
            this.buttonvendorAdd.Click += new System.EventHandler(this.vendorAdd);
            // 
            // FormModel
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(364, 181);
            this.Controls.Add(this.buttonvendorAdd);
            this.Controls.Add(this.buttonTEAdd);
            this.Controls.Add(this.combovendor);
            this.Controls.Add(this.labelvendor);
            this.Controls.Add(this.comboEqType);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelEqType);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combovendor;
        private System.Windows.Forms.Label labelvendor;
        private System.Windows.Forms.ComboBox comboEqType;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelEqType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonTEAdd;
        private System.Windows.Forms.Button buttonvendorAdd;
    }
}