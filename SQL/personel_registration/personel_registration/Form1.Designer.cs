namespace personel_registration
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            maskedTextBoxsalary = new MaskedTextBox();
            label7 = new Label();
            textBoxocc = new TextBox();
            groupBox2 = new GroupBox();
            buttongraphics = new Button();
            buttonstatics = new Button();
            buttonclear = new Button();
            buttonupdate = new Button();
            buttondelete = new Button();
            buttonsave = new Button();
            buttonlist = new Button();
            label6 = new Label();
            label5 = new Label();
            radioButtonsingle = new RadioButton();
            radioButtonmarried = new RadioButton();
            comboBoxcity = new ComboBox();
            label4 = new Label();
            textlname = new TextBox();
            label3 = new Label();
            textname = new TextBox();
            label2 = new Label();
            textid = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(maskedTextBoxsalary);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxocc);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButtonsingle);
            groupBox1.Controls.Add(radioButtonmarried);
            groupBox1.Controls.Add(comboBoxcity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textlname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textid);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 458);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Registration";
            // 
            // maskedTextBoxsalary
            // 
            maskedTextBoxsalary.Location = new Point(147, 267);
            maskedTextBoxsalary.Mask = "0000";
            maskedTextBoxsalary.Name = "maskedTextBoxsalary";
            maskedTextBoxsalary.Size = new Size(160, 24);
            maskedTextBoxsalary.TabIndex = 14;
            maskedTextBoxsalary.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(91, 267);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 13;
            label7.Text = "Salary:";
            // 
            // textBoxocc
            // 
            textBoxocc.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxocc.Location = new Point(147, 354);
            textBoxocc.Name = "textBoxocc";
            textBoxocc.Size = new Size(160, 27);
            textBoxocc.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(buttongraphics);
            groupBox2.Controls.Add(buttonstatics);
            groupBox2.Controls.Add(buttonclear);
            groupBox2.Controls.Add(buttonupdate);
            groupBox2.Controls.Add(buttondelete);
            groupBox2.Controls.Add(buttonsave);
            groupBox2.Controls.Add(buttonlist);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(437, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 409);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Processes";
            // 
            // buttongraphics
            // 
            buttongraphics.BackColor = SystemColors.ActiveCaption;
            buttongraphics.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttongraphics.ForeColor = SystemColors.ButtonFace;
            buttongraphics.Location = new Point(63, 331);
            buttongraphics.Name = "buttongraphics";
            buttongraphics.Size = new Size(94, 38);
            buttongraphics.TabIndex = 6;
            buttongraphics.Text = "Graphics";
            buttongraphics.UseVisualStyleBackColor = false;
            // 
            // buttonstatics
            // 
            buttonstatics.BackColor = SystemColors.ActiveCaption;
            buttonstatics.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonstatics.ForeColor = SystemColors.ButtonFace;
            buttonstatics.Location = new Point(63, 283);
            buttonstatics.Name = "buttonstatics";
            buttonstatics.Size = new Size(94, 38);
            buttonstatics.TabIndex = 5;
            buttonstatics.Text = "Statics";
            buttonstatics.UseVisualStyleBackColor = false;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = SystemColors.ActiveCaption;
            buttonclear.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonclear.ForeColor = SystemColors.ButtonFace;
            buttonclear.Location = new Point(63, 234);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(94, 38);
            buttonclear.TabIndex = 4;
            buttonclear.Text = "Clear";
            buttonclear.UseVisualStyleBackColor = false;
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = SystemColors.ActiveCaption;
            buttonupdate.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonupdate.ForeColor = SystemColors.ButtonFace;
            buttonupdate.Location = new Point(63, 185);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(94, 38);
            buttonupdate.TabIndex = 3;
            buttonupdate.Text = "Update";
            buttonupdate.UseVisualStyleBackColor = false;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = SystemColors.ActiveCaption;
            buttondelete.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttondelete.ForeColor = SystemColors.ButtonFace;
            buttondelete.Location = new Point(63, 141);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(94, 38);
            buttondelete.TabIndex = 2;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.ActiveCaption;
            buttonsave.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsave.ForeColor = SystemColors.ButtonFace;
            buttonsave.Location = new Point(63, 97);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(94, 38);
            buttonsave.TabIndex = 1;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            // 
            // buttonlist
            // 
            buttonlist.BackColor = SystemColors.ActiveCaption;
            buttonlist.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonlist.ForeColor = SystemColors.ButtonFace;
            buttonlist.Location = new Point(63, 52);
            buttonlist.Name = "buttonlist";
            buttonlist.Size = new Size(94, 38);
            buttonlist.TabIndex = 0;
            buttonlist.Text = "List";
            buttonlist.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(58, 361);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 11;
            label6.Text = "Occupation:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 314);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 10;
            label5.Text = "Condition:";
            // 
            // radioButtonsingle
            // 
            radioButtonsingle.AutoSize = true;
            radioButtonsingle.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonsingle.Location = new Point(236, 314);
            radioButtonsingle.Name = "radioButtonsingle";
            radioButtonsingle.Size = new Size(64, 23);
            radioButtonsingle.TabIndex = 9;
            radioButtonsingle.TabStop = true;
            radioButtonsingle.Text = "Single";
            radioButtonsingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonmarried
            // 
            radioButtonmarried.AutoSize = true;
            radioButtonmarried.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonmarried.Location = new Point(147, 314);
            radioButtonmarried.Name = "radioButtonmarried";
            radioButtonmarried.Size = new Size(78, 23);
            radioButtonmarried.TabIndex = 8;
            radioButtonmarried.TabStop = true;
            radioButtonmarried.Text = "Married";
            radioButtonmarried.UseVisualStyleBackColor = true;
            // 
            // comboBoxcity
            // 
            comboBoxcity.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxcity.FormattingEnabled = true;
            comboBoxcity.Location = new Point(147, 221);
            comboBoxcity.Name = "comboBoxcity";
            comboBoxcity.Size = new Size(160, 27);
            comboBoxcity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(102, 229);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 6;
            label4.Text = "City:";
            // 
            // textlname
            // 
            textlname.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textlname.Location = new Point(147, 176);
            textlname.Name = "textlname";
            textlname.Size = new Size(160, 27);
            textlname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 176);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 4;
            label3.Text = "Lastname:";
            // 
            // textname
            // 
            textname.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textname.Location = new Point(147, 133);
            textname.Name = "textname";
            textname.Size = new Size(160, 27);
            textname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 136);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // textid
            // 
            textid.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textid.Location = new Point(147, 86);
            textid.Name = "textid";
            textid.Size = new Size(160, 27);
            textid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 89);
            label1.Name = "label1";
            label1.Size = new Size(29, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 485);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(801, 270);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Register";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(795, 247);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(823, 769);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textid;
        private Label label1;
        private Label label5;
        private RadioButton radioButtonsingle;
        private RadioButton radioButtonmarried;
        private ComboBox comboBoxcity;
        private Label label4;
        private TextBox textlname;
        private Label label3;
        private TextBox textname;
        private Label label2;
        private TextBox textBoxocc;
        private Label label6;
        private GroupBox groupBox2;
        private Button buttongraphics;
        private Button buttonstatics;
        private Button buttonclear;
        private Button buttonupdate;
        private Button buttondelete;
        private Button buttonsave;
        private Button buttonlist;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBoxsalary;
        private Label label7;
    }
}