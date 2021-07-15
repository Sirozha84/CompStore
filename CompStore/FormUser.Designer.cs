
namespace CompStore
{
    partial class FormUser
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
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.textO = new System.Windows.Forms.TextBox();
            this.labelO = new System.Windows.Forms.Label();
            this.textI = new System.Windows.Forms.TextBox();
            this.labelI = new System.Windows.Forms.Label();
            this.textF = new System.Windows.Forms.TextBox();
            this.labelF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDis = new System.Windows.Forms.DateTimePicker();
            this.dateEmp = new System.Windows.Forms.DateTimePicker();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.comboPost = new System.Windows.Forms.ComboBox();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(166, 276);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "Записать";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(247, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboDep
            // 
            this.comboDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Location = new System.Drawing.Point(120, 117);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(202, 21);
            this.comboDep.TabIndex = 6;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(24, 120);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(90, 13);
            this.labelDep.TabIndex = 80;
            this.labelDep.Text = "Подразделение:";
            // 
            // textO
            // 
            this.textO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textO.Location = new System.Drawing.Point(120, 64);
            this.textO.Name = "textO";
            this.textO.Size = new System.Drawing.Size(202, 20);
            this.textO.TabIndex = 2;
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(57, 67);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(57, 13);
            this.labelO.TabIndex = 78;
            this.labelO.Text = "Отчество:";
            // 
            // textI
            // 
            this.textI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textI.Location = new System.Drawing.Point(120, 38);
            this.textI.Name = "textI";
            this.textI.Size = new System.Drawing.Size(202, 20);
            this.textI.TabIndex = 1;
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(82, 41);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(32, 13);
            this.labelI.TabIndex = 76;
            this.labelI.Text = "Имя:";
            // 
            // textF
            // 
            this.textF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textF.Location = new System.Drawing.Point(120, 12);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(202, 20);
            this.textF.TabIndex = 0;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(55, 15);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(59, 13);
            this.labelF.TabIndex = 74;
            this.labelF.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Дата увольнения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Дата приёма:";
            // 
            // dateDis
            // 
            this.dateDis.Checked = false;
            this.dateDis.Location = new System.Drawing.Point(120, 197);
            this.dateDis.Name = "dateDis";
            this.dateDis.ShowCheckBox = true;
            this.dateDis.Size = new System.Drawing.Size(157, 20);
            this.dateDis.TabIndex = 9;
            // 
            // dateEmp
            // 
            this.dateEmp.Location = new System.Drawing.Point(120, 171);
            this.dateEmp.Name = "dateEmp";
            this.dateEmp.ShowCheckBox = true;
            this.dateEmp.Size = new System.Drawing.Size(157, 20);
            this.dateEmp.TabIndex = 8;
            // 
            // comboRoom
            // 
            this.comboRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(120, 90);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(202, 21);
            this.comboRoom.TabIndex = 5;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(46, 93);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(71, 13);
            this.labelRoom.TabIndex = 68;
            this.labelRoom.Text = "Помещение:";
            // 
            // comboPost
            // 
            this.comboPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPost.FormattingEnabled = true;
            this.comboPost.Location = new System.Drawing.Point(120, 144);
            this.comboPost.Name = "comboPost";
            this.comboPost.Size = new System.Drawing.Size(202, 21);
            this.comboPost.TabIndex = 7;
            // 
            // textCom
            // 
            this.textCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCom.Location = new System.Drawing.Point(120, 223);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(202, 47);
            this.textCom.TabIndex = 10;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(41, 226);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 65;
            this.labelCom.Text = "Примечание:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(46, 147);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 63;
            this.labelPost.Text = "Должность:";
            // 
            // FormUser
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.comboDep);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.textO);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.textI);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDis);
            this.Controls.Add(this.dateEmp);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.comboPost);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.TextBox textO;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.TextBox textI;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDis;
        private System.Windows.Forms.DateTimePicker dateEmp;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ComboBox comboPost;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelPost;
    }
}