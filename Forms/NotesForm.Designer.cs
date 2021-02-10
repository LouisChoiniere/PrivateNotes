
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listPanel.SuspendLayout();
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
            this.addNoteButton.Size = new System.Drawing.Size(260, 23);
            this.addNoteButton.TabIndex = 5;
            this.addNoteButton.Text = "+ Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // notesPanel
            // 
            this.notesPanel.AutoScroll = true;
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
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(277, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(985, 655);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 652);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.listPanel);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel yeet;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.FlowLayoutPanel notesPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel mainPanel;
    }
}