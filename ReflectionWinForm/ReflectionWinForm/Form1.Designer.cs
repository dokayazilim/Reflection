namespace ReflectionWinForm
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
            btnGetir = new Button();
            txt_object = new TextBox();
            groupBox2 = new GroupBox();
            lst_ctors = new ListBox();
            groupBox3 = new GroupBox();
            lst_props = new ListBox();
            groupBox4 = new GroupBox();
            lst_meths = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetir);
            groupBox1.Controls.Add(txt_object);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lütfen Bilgi almak istediğiniz class' ın tam adını giriniz";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(661, 24);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(94, 29);
            btnGetir.TabIndex = 1;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // txt_object
            // 
            txt_object.Location = new Point(6, 26);
            txt_object.Name = "txt_object";
            txt_object.Size = new Size(617, 27);
            txt_object.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lst_ctors);
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CTOR";
            // 
            // lst_ctors
            // 
            lst_ctors.FormattingEnabled = true;
            lst_ctors.ItemHeight = 20;
            lst_ctors.Location = new Point(6, 26);
            lst_ctors.Name = "lst_ctors";
            lst_ctors.Size = new Size(238, 344);
            lst_ctors.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lst_props);
            groupBox3.Location = new Point(282, 94);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 389);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Properties";
            // 
            // lst_props
            // 
            lst_props.FormattingEnabled = true;
            lst_props.ItemHeight = 20;
            lst_props.Location = new Point(6, 26);
            lst_props.Name = "lst_props";
            lst_props.Size = new Size(238, 344);
            lst_props.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lst_meths);
            groupBox4.Location = new Point(538, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 389);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Methods";
            // 
            // lst_meths
            // 
            lst_meths.FormattingEnabled = true;
            lst_meths.ItemHeight = 20;
            lst_meths.Location = new Point(6, 26);
            lst_meths.Name = "lst_meths";
            lst_meths.Size = new Size(238, 344);
            lst_meths.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 495);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGetir;
        private TextBox txt_object;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ListBox lst_ctors;
        private ListBox lst_props;
        private ListBox lst_meths;
    }
}