
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
            this.components = new System.ComponentModel.Container();
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
            this.toolTipS = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipI = new System.Windows.Forms.ToolTip(this.components);
            this.checkINV = new System.Windows.Forms.CheckBox();
            this.buttonModelAdd = new System.Windows.Forms.Button();
            this.textMac = new System.Windows.Forms.TextBox();
            this.labelMac = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textProp = new System.Windows.Forms.TextBox();
            this.labelProp = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(216, 346);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Записать";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 346);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(140, 259);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(232, 81);
            this.textCom.TabIndex = 9;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(61, 262);
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
            this.textSN.TabIndex = 1;
            this.textSN.TextChanged += new System.EventHandler(this.CheckField);
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
            this.comboModel.Size = new System.Drawing.Size(205, 21);
            this.comboModel.TabIndex = 0;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.CheckField);
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
            this.textIN.Size = new System.Drawing.Size(151, 20);
            this.textIN.TabIndex = 2;
            this.textIN.TextChanged += new System.EventHandler(this.CheckField);
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
            this.labelBuyDate.Location = new System.Drawing.Point(54, 210);
            this.labelBuyDate.Name = "labelBuyDate";
            this.labelBuyDate.Size = new System.Drawing.Size(80, 13);
            this.labelBuyDate.TabIndex = 74;
            this.labelBuyDate.Text = "Дата покупки:";
            // 
            // dateBuy
            // 
            this.dateBuy.Location = new System.Drawing.Point(140, 207);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.ShowCheckBox = true;
            this.dateBuy.Size = new System.Drawing.Size(140, 20);
            this.dateBuy.TabIndex = 7;
            // 
            // checkINV
            // 
            this.checkINV.AutoSize = true;
            this.checkINV.Location = new System.Drawing.Point(297, 67);
            this.checkINV.Name = "checkINV";
            this.checkINV.Size = new System.Drawing.Size(77, 17);
            this.checkINV.TabIndex = 3;
            this.checkINV.Text = "Валидный";
            this.toolTipI.SetToolTip(this.checkINV, "На корпусе устройства указан верный инвентарный номер");
            this.checkINV.UseVisualStyleBackColor = true;
            // 
            // buttonModelAdd
            // 
            this.buttonModelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModelAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonModelAdd.Location = new System.Drawing.Point(350, 11);
            this.buttonModelAdd.Name = "buttonModelAdd";
            this.buttonModelAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonModelAdd.TabIndex = 12;
            this.buttonModelAdd.UseVisualStyleBackColor = true;
            this.buttonModelAdd.Click += new System.EventHandler(this.ModelAdd);
            // 
            // textMac
            // 
            this.textMac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMac.Location = new System.Drawing.Point(140, 91);
            this.textMac.Name = "textMac";
            this.textMac.Size = new System.Drawing.Size(232, 20);
            this.textMac.TabIndex = 4;
            // 
            // labelMac
            // 
            this.labelMac.AutoSize = true;
            this.labelMac.Location = new System.Drawing.Point(68, 94);
            this.labelMac.Name = "labelMac";
            this.labelMac.Size = new System.Drawing.Size(66, 13);
            this.labelMac.TabIndex = 78;
            this.labelMac.Text = "MAC-адрес:";
            // 
            // textIP
            // 
            this.textIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIP.Location = new System.Drawing.Point(140, 117);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(232, 20);
            this.textIP.TabIndex = 5;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(81, 120);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(53, 13);
            this.labelIP.TabIndex = 80;
            this.labelIP.Text = "IP-адрес:";
            // 
            // textProp
            // 
            this.textProp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textProp.Location = new System.Drawing.Point(140, 143);
            this.textProp.Multiline = true;
            this.textProp.Name = "textProp";
            this.textProp.Size = new System.Drawing.Size(232, 58);
            this.textProp.TabIndex = 6;
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Location = new System.Drawing.Point(41, 146);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(93, 13);
            this.labelProp.TabIndex = 82;
            this.labelProp.Text = "Характеристики:";
            // 
            // textPrice
            // 
            this.textPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrice.Location = new System.Drawing.Point(140, 233);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(232, 20);
            this.textPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(98, 236);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 84;
            this.labelPrice.Text = "Цена:";
            // 
            // FormEquipment
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textProp);
            this.Controls.Add(this.labelProp);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textMac);
            this.Controls.Add(this.labelMac);
            this.Controls.Add(this.checkINV);
            this.Controls.Add(this.buttonModelAdd);
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
        private System.Windows.Forms.ToolTip toolTipS;
        private System.Windows.Forms.ToolTip toolTipI;
        private System.Windows.Forms.Button buttonModelAdd;
        private System.Windows.Forms.CheckBox checkINV;
        private System.Windows.Forms.TextBox textMac;
        private System.Windows.Forms.Label labelMac;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textProp;
        private System.Windows.Forms.Label labelProp;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}