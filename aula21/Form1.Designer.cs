namespace aula21
{
    partial class Register
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
            Label label_name;
            field_name = new TextBox();
            send = new Button();
            label_name = new Label();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(15, 13);
            label_name.Name = "label_name";
            label_name.Size = new Size(40, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Nome";
            label_name.Click += label1_Click;
            // 
            // field_name
            // 
            field_name.Location = new Point(58, 10);
            field_name.Name = "field_name";
            field_name.Size = new Size(286, 23);
            field_name.TabIndex = 1;
            // 
            // send
            // 
            send.Location = new Point(269, 393);
            send.Name = "send";
            send.Size = new Size(75, 23);
            send.TabIndex = 2;
            send.Text = "Concluir";
            send.UseVisualStyleBackColor = true;
            send.Click += sendForm;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(356, 428);
            Controls.Add(send);
            Controls.Add(field_name);
            Controls.Add(label_name);
            Name = "Register";
            Text = "Registro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private TextBox field_name;
        private Button send;
    }
}