
namespace PrivateNotes.Forms {
    partial class NotesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listPanel = new System.Windows.Forms.Panel();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.notesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.yeet = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.noteInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.addNoteButton);
            this.listPanel.Controls.Add(this.notesPanel);
            this.listPanel.Controls.Add(this.title);
            this.listPanel.Controls.Add(this.yeet);
            this.listPanel.Location = new System.Drawing.Point(1, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(274, 655);
            this.listPanel.TabIndex = 0;
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(0, 60);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(270, 23);
            this.addNoteButton.TabIndex = 5;
            this.addNoteButton.Text = "+ Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            // 
            // notesPanel
            // 
            this.notesPanel.Location = new System.Drawing.Point(0, 89);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(270, 551);
            this.notesPanel.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(11, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(221, 40);
            this.title.TabIndex = 3;
            this.title.Text = "Private Notes";
            // 
            // yeet
            // 
            this.yeet.Location = new System.Drawing.Point(276, 0);
            this.yeet.Name = "yeet";
            this.yeet.Size = new System.Drawing.Size(200, 100);
            this.yeet.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.titleInput);
            this.panel1.Controls.Add(this.noteInput);
            this.panel1.Location = new System.Drawing.Point(277, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 655);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInput.Location = new System.Drawing.Point(86, 70);
            this.titleInput.Multiline = true;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(358, 30);
            this.titleInput.TabIndex = 2;
            this.titleInput.Text = "asd";
            // 
            // noteInput
            // 
            this.noteInput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteInput.Location = new System.Drawing.Point(86, 127);
            this.noteInput.Multiline = true;
            this.noteInput.Name = "noteInput";
            this.noteInput.Size = new System.Drawing.Size(798, 453);
            this.noteInput.TabIndex = 1;
            this.noteInput.Text = "ye3\r\nsad\r\n";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(632, 598);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(252, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Note";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(790, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AES";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(790, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rijndael";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listPanel);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel yeet;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.FlowLayoutPanel notesPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox noteInput;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}