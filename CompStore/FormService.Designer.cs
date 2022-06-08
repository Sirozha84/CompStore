namespace CompStore
{
    partial class FormService
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
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonConAdd = new System.Windows.Forms.Button();
            this.buttonEquipmentAdd = new System.Windows.Forms.Button();
            this.comboCon = new System.Windows.Forms.ComboBox();
            this.labelCon = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateService = new System.Windows.Forms.DateTimePicker();
            this.comboEquipment = new System.Windows.Forms.ComboBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.checkPrinter = new System.Windows.Forms.CheckBox();
            this.textCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(84, 118);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(50, 13);
            this.labelCount.TabIndex = 113;
            this.labelCount.Text = "Счётчик:";
            // 
            // buttonConAdd
            // 
            this.buttonConAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonConAdd.Location = new System.Drawing.Point(450, 87);
            this.buttonConAdd.Name = "buttonConAdd";
            this.buttonConAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonConAdd.TabIndex = 5;
            this.buttonConAdd.UseVisualStyleBackColor = true;
            this.buttonConAdd.Click += new System.EventHandler(this.ConsumableAdd);
            // 
            // buttonEquipmentAdd
            // 
            this.buttonEquipmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEquipmentAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonEquipmentAdd.Location = new System.Drawing.Point(450, 37);
            this.buttonEquipmentAdd.Name = "buttonEquipmentAdd";
            this.buttonEquipmentAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonEquipmentAdd.TabIndex = 2;
            this.buttonEquipmentAdd.UseVisualStyleBackColor = true;
            this.buttonEquipmentAdd.Click += new System.EventHandler(this.EquipmentAdd);
            // 
            // comboCon
            // 
            this.comboCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCon.FormattingEnabled = true;
            this.comboCon.Location = new System.Drawing.Point(140, 88);
            this.comboCon.Name = "comboCon";
            this.comboCon.Size = new System.Drawing.Size(305, 21);
            this.comboCon.TabIndex = 4;
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Location = new System.Drawing.Point(70, 91);
            this.labelCon.Name = "labelCon";
            this.labelCon.Size = new System.Drawing.Size(64, 13);
            this.labelCon.TabIndex = 112;
            this.labelCon.Text = "Расходник:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(22, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(112, 13);
            this.labelDate.TabIndex = 110;
            this.labelDate.Text = "Дата обслуживания:";
            // 
            // dateService
            // 
            this.dateService.Location = new System.Drawing.Point(140, 12);
            this.dateService.Name = "dateService";
            this.dateService.Size = new System.Drawing.Size(140, 20);
            this.dateService.TabIndex = 0;
            // 
            // comboEquipment
            // 
            this.comboEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEquipment.FormattingEnabled = true;
            this.comboEquipment.Location = new System.Drawing.Point(140, 38);
            this.comboEquipment.Name = "comboEquipment";
            this.comboEquipment.Size = new System.Drawing.Size(305, 21);
            this.comboEquipment.TabIndex = 1;
            this.comboEquipment.SelectedIndexChanged += new System.EventHandler(this.EquipmentSelect);
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(51, 41);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(83, 13);
            this.labelEquipment.TabIndex = 109;
            this.labelEquipment.Text = "Оборудование:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(316, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Записать";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(140, 141);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(332, 79);
            this.textCom.TabIndex = 7;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(61, 144);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 108;
            this.labelCom.Text = "Примечание:";
            // 
            // checkPrinter
            // 
            this.checkPrinter.AutoSize = true;
            this.checkPrinter.Location = new System.Drawing.Point(140, 65);
            this.checkPrinter.Name = "checkPrinter";
            this.checkPrinter.Size = new System.Drawing.Size(75, 17);
            this.checkPrinter.TabIndex = 3;
            this.checkPrinter.Text = "Заправка";
            this.checkPrinter.UseVisualStyleBackColor = true;
            this.checkPrinter.CheckedChanged += new System.EventHandler(this.PrinterCheck);
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(140, 115);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(100, 20);
            this.textCount.TabIndex = 6;
            // 
            // FormService
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.checkPrinter);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonConAdd);
            this.Controls.Add(this.buttonEquipmentAdd);
            this.Controls.Add(this.comboCon);
            this.Controls.Add(this.labelCon);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateService);
            this.Controls.Add(this.comboEquipment);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormService";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonConAdd;
        private System.Windows.Forms.Button buttonEquipmentAdd;
        private System.Windows.Forms.ComboBox comboCon;
        private System.Windows.Forms.Label labelCon;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateService;
        private System.Windows.Forms.ComboBox comboEquipment;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.CheckBox checkPrinter;
        private System.Windows.Forms.TextBox textCount;
    }
}