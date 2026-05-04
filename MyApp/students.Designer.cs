namespace MyApp
{
    partial class students
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
            label1 = new Label();
            studIdTxt = new MaskedTextBox();
            nameTxt = new MaskedTextBox();
            label2 = new Label();
            emailTxt = new MaskedTextBox();
            label3 = new Label();
            progTxt = new MaskedTextBox();
            label4 = new Label();
            studData = new DataGridView();
            addBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(13, 37);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // studIdTxt
            // 
            studIdTxt.Font = new Font("Segoe UI", 14F);
            studIdTxt.Location = new Point(148, 30);
            studIdTxt.Name = "studIdTxt";
            studIdTxt.Size = new Size(232, 32);
            studIdTxt.TabIndex = 1;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 14F);
            nameTxt.Location = new Point(148, 87);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(232, 32);
            nameTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 94);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 14F);
            emailTxt.Location = new Point(148, 145);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(232, 32);
            emailTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // progTxt
            // 
            progTxt.Font = new Font("Segoe UI", 14F);
            progTxt.Location = new Point(148, 201);
            progTxt.Name = "progTxt";
            progTxt.Size = new Size(232, 32);
            progTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(13, 208);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 6;
            label4.Text = "Programme";
            // 
            // studData
            // 
            studData.BackgroundColor = Color.DarkTurquoise;
            studData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studData.Location = new Point(426, 30);
            studData.Name = "studData";
            studData.Size = new Size(497, 283);
            studData.TabIndex = 8;
            
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Green;
            addBtn.Font = new Font("Segoe UI", 14F);
            addBtn.ForeColor = SystemColors.ButtonHighlight;
            addBtn.Location = new Point(14, 275);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(87, 38);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.Font = new Font("Segoe UI", 14F);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Location = new Point(128, 275);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(87, 38);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Indigo;
            updateBtn.Font = new Font("Segoe UI", 14F);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(241, 275);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(87, 38);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.BlueViolet;
            resetBtn.Font = new Font("Segoe UI", 14F);
            resetBtn.ForeColor = SystemColors.ButtonHighlight;
            resetBtn.Location = new Point(14, 319);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(87, 38);
            resetBtn.TabIndex = 12;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 450);
            Controls.Add(resetBtn);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(studData);
            Controls.Add(progTxt);
            Controls.Add(label4);
            Controls.Add(emailTxt);
            Controls.Add(label3);
            Controls.Add(nameTxt);
            Controls.Add(label2);
            Controls.Add(studIdTxt);
            Controls.Add(label1);
            Name = "students";
            Text = "Students Form";
            ((System.ComponentModel.ISupportInitialize)studData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox studIdTxt;
        private MaskedTextBox nameTxt;
        private Label label2;
        private MaskedTextBox emailTxt;
        private Label label3;
        private MaskedTextBox progTxt;
        private Label label4;
        private DataGridView studData;
        private Button addBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button resetBtn;
    }
}
