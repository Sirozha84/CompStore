
namespace CompStore
{
    partial class FormMove
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
            this.labelDate = new System.Windows.Forms.Label();
            this.dateMove = new System.Windows.Forms.DateTimePicker();
            this.comboEquipment = new System.Windows.Forms.ComboBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.buttonEquipmentAdd = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonRoomAdd = new System.Windows.Forms.Button();
            this.buttonMOLAdd = new System.Windows.Forms.Button();
            this.comboMOL = new System.Windows.Forms.ComboBox();
            this.labelMOL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 96);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(110, 13);
            this.labelDate.TabIndex = 86;
            this.labelDate.Text = "Дата перемещения:";
            // 
            // dateMove
            // 
            this.dateMove.Location = new System.Drawing.Point(140, 93);
            this.dateMove.Name = "dateMove";
            this.dateMove.Size = new System.Drawing.Size(140, 20);
            this.dateMove.TabIndex = 3;
            // 
            // comboEquipment
            // 
            this.comboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEquipment.FormattingEnabled = true;
            this.comboEquipment.Location = new System.Drawing.Point(140, 12);
            this.comboEquipment.Name = "comboEquipment";
            this.comboEquipment.Size = new System.Drawing.Size(305, 21);
            this.comboEquipment.TabIndex = 0;
            this.comboEquipment.SelectedIndexChanged += new System.EventHandler(this.EquipmentSelect);
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(51, 15);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(83, 13);
            this.labelEquipment.TabIndex = 84;
            this.labelEquipment.Text = "Оборудование:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(316, 226);
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
            this.buttonCancel.Location = new System.Drawing.Point(397, 226);
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
            this.textCom.Location = new System.Drawing.Point(140, 147);
            this.textCom.Multiline = true;
            this.textCom.Name = "textCom";
            this.textCom.Size = new System.Drawing.Size(332, 73);
            this.textCom.TabIndex = 5;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(63, 150);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(73, 13);
            this.labelCom.TabIndex = 83;
            this.labelCom.Text = "Примечание:";
            // 
            // comboUser
            // 
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(140, 39);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(305, 21);
            this.comboUser.TabIndex = 1;
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.UserSelect);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(71, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(63, 13);
            this.labelUser.TabIndex = 88;
            this.labelUser.Text = "Сотрудник:";
            // 
            // comboRoom
            // 
            this.comboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(140, 66);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(305, 21);
            this.comboRoom.TabIndex = 2;
            this.comboRoom.SelectedIndexChanged += new System.EventHandler(this.EnterCheck);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(63, 69);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(71, 13);
            this.labelRoom.TabIndex = 90;
            this.labelRoom.Text = "Помещение:";
            // 
            // buttonEquipmentAdd
            // 
            this.buttonEquipmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEquipmentAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonEquipmentAdd.Location = new System.Drawing.Point(450, 11);
            this.buttonEquipmentAdd.Name = "buttonEquipmentAdd";
            this.buttonEquipmentAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonEquipmentAdd.TabIndex = 8;
            this.buttonEquipmentAdd.UseVisualStyleBackColor = true;
            this.buttonEquipmentAdd.Click += new System.EventHandler(this.EquipmentAdd);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUserAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonUserAdd.Location = new System.Drawing.Point(450, 38);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonUserAdd.TabIndex = 9;
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.UserAdd);
            // 
            // buttonRoomAdd
            // 
            this.buttonRoomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRoomAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonRoomAdd.Location = new System.Drawing.Point(450, 65);
            this.buttonRoomAdd.Name = "buttonRoomAdd";
            this.buttonRoomAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonRoomAdd.TabIndex = 10;
            this.buttonRoomAdd.UseVisualStyleBackColor = true;
            this.buttonRoomAdd.Click += new System.EventHandler(this.RoomAdd);
            // 
            // buttonMOLAdd
            // 
            this.buttonMOLAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMOLAdd.Image = global::CompStore.Properties.Resources.add;
            this.buttonMOLAdd.Location = new System.Drawing.Point(450, 118);
            this.buttonMOLAdd.Name = "buttonMOLAdd";
            this.buttonMOLAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonMOLAdd.TabIndex = 11;
            this.buttonMOLAdd.UseVisualStyleBackColor = true;
            this.buttonMOLAdd.Click += new System.EventHandler(this.MOLAdd);
            // 
            // comboMOL
            // 
            this.comboMOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMOL.FormattingEnabled = true;
            this.comboMOL.Location = new System.Drawing.Point(140, 119);
            this.comboMOL.Name = "comboMOL";
            this.comboMOL.Size = new System.Drawing.Size(305, 21);
            this.comboMOL.TabIndex = 4;
            // 
            // labelMOL
            // 
            this.labelMOL.AutoSize = true;
            this.labelMOL.Location = new System.Drawing.Point(51, 122);
            this.labelMOL.Name = "labelMOL";
            this.labelMOL.Size = new System.Drawing.Size(83, 13);
            this.labelMOL.TabIndex = 95;
            this.labelMOL.Text = "Мат. отв. лицо:";
            // 
            // FormMove
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonMOLAdd);
            this.Controls.Add(this.comboMOL);
            this.Controls.Add(this.labelMOL);
            this.Controls.Add(this.buttonRoomAdd);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.buttonEquipmentAdd);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateMove);
            this.Controls.Add(this.comboEquipment);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMove";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateMove;
        private System.Windows.Forms.ComboBox comboEquipment;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Button buttonEquipmentAdd;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonRoomAdd;
        private System.Windows.Forms.Button buttonMOLAdd;
        private System.Windows.Forms.ComboBox comboMOL;
        private System.Windows.Forms.Label labelMOL;
    }
}