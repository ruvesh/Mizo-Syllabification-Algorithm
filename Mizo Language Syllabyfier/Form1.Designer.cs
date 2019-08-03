namespace Mizo_Language_Syllabyfier
{
    partial class MizoSyllabifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MizoSyllabifier));
            this.enter_text = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.Syllable = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.syllabify_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter_text
            // 
            this.enter_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter_text.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_text.Location = new System.Drawing.Point(37, 28);
            this.enter_text.Multiline = true;
            this.enter_text.Name = "enter_text";
            this.enter_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.enter_text.Size = new System.Drawing.Size(705, 222);
            this.enter_text.TabIndex = 0;
            this.enter_text.Text = "Mizo Text";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(162, 272);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 2;
            // 
            // Syllable
            // 
            this.Syllable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Syllable.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syllable.Location = new System.Drawing.Point(37, 265);
            this.Syllable.Multiline = true;
            this.Syllable.Name = "Syllable";
            this.Syllable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Syllable.Size = new System.Drawing.Size(705, 224);
            this.Syllable.TabIndex = 4;
            this.Syllable.Text = "Syllables";
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Location = new System.Drawing.Point(601, 519);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(141, 63);
            this.save.TabIndex = 5;
            this.save.Text = "Save to File";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load.Location = new System.Drawing.Point(37, 519);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(132, 63);
            this.load.TabIndex = 6;
            this.load.Text = "Load from file";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // syllabify_button
            // 
            this.syllabify_button.Location = new System.Drawing.Point(310, 519);
            this.syllabify_button.Name = "syllabify_button";
            this.syllabify_button.Size = new System.Drawing.Size(132, 63);
            this.syllabify_button.TabIndex = 7;
            this.syllabify_button.Text = "Syllabify";
            this.syllabify_button.UseVisualStyleBackColor = true;
            this.syllabify_button.Click += new System.EventHandler(this.syllabify_button_Click);
            // 
            // MizoSyllabifier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(773, 594);
            this.Controls.Add(this.syllabify_button);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Syllable);
            this.Controls.Add(this.result);
            this.Controls.Add(this.enter_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MizoSyllabifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mizo Language Syllabifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MizoSyllabifier_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enter_text;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox Syllable;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button syllabify_button;
    }
}

