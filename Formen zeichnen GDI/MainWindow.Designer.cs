namespace Formen_zeichnen_GDI
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Kreis = new System.Windows.Forms.RadioButton();
            this.radioButton_Quadrat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_Size = new System.Windows.Forms.TrackBar();
            this.button_Draw = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_AnimationYes = new System.Windows.Forms.RadioButton();
            this.radioButton_AnimationNo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Canvas
            // 
            this.panel_Canvas.BackColor = System.Drawing.Color.White;
            this.panel_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Canvas.Location = new System.Drawing.Point(12, 12);
            this.panel_Canvas.Name = "panel_Canvas";
            this.panel_Canvas.Size = new System.Drawing.Size(300, 300);
            this.panel_Canvas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canvas size = 300 x 300 px.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Kreis);
            this.groupBox1.Controls.Add(this.radioButton_Quadrat);
            this.groupBox1.Location = new System.Drawing.Point(332, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figur";
            // 
            // radioButton_Kreis
            // 
            this.radioButton_Kreis.AutoSize = true;
            this.radioButton_Kreis.Location = new System.Drawing.Point(76, 20);
            this.radioButton_Kreis.Name = "radioButton_Kreis";
            this.radioButton_Kreis.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Kreis.TabIndex = 0;
            this.radioButton_Kreis.TabStop = true;
            this.radioButton_Kreis.Text = "Kreis";
            this.radioButton_Kreis.UseVisualStyleBackColor = true;
            // 
            // radioButton_Quadrat
            // 
            this.radioButton_Quadrat.AutoSize = true;
            this.radioButton_Quadrat.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Quadrat.Name = "radioButton_Quadrat";
            this.radioButton_Quadrat.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Quadrat.TabIndex = 0;
            this.radioButton_Quadrat.TabStop = true;
            this.radioButton_Quadrat.Text = "Quadrat";
            this.radioButton_Quadrat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar_Size);
            this.groupBox2.Location = new System.Drawing.Point(332, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figurgöße";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "klein";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "mittel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "groß";
            // 
            // trackBar_Size
            // 
            this.trackBar_Size.Location = new System.Drawing.Point(7, 28);
            this.trackBar_Size.Maximum = 3;
            this.trackBar_Size.Minimum = 1;
            this.trackBar_Size.Name = "trackBar_Size";
            this.trackBar_Size.Size = new System.Drawing.Size(168, 45);
            this.trackBar_Size.TabIndex = 0;
            this.trackBar_Size.Value = 1;
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(438, 219);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(75, 23);
            this.button_Draw.TabIndex = 4;
            this.button_Draw.Text = "Zeichnen";
            this.button_Draw.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(332, 219);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(438, 309);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Beenden";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_AnimationNo);
            this.groupBox3.Controls.Add(this.radioButton_AnimationYes);
            this.groupBox3.Location = new System.Drawing.Point(332, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 47);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animation";
            // 
            // radioButton_AnimationYes
            // 
            this.radioButton_AnimationYes.AutoSize = true;
            this.radioButton_AnimationYes.Location = new System.Drawing.Point(7, 19);
            this.radioButton_AnimationYes.Name = "radioButton_AnimationYes";
            this.radioButton_AnimationYes.Size = new System.Drawing.Size(33, 17);
            this.radioButton_AnimationYes.TabIndex = 0;
            this.radioButton_AnimationYes.TabStop = true;
            this.radioButton_AnimationYes.Text = "ja";
            this.radioButton_AnimationYes.UseVisualStyleBackColor = true;
            // 
            // radioButton_AnimationNo
            // 
            this.radioButton_AnimationNo.AutoSize = true;
            this.radioButton_AnimationNo.Location = new System.Drawing.Point(106, 19);
            this.radioButton_AnimationNo.Name = "radioButton_AnimationNo";
            this.radioButton_AnimationNo.Size = new System.Drawing.Size(45, 17);
            this.radioButton_AnimationNo.TabIndex = 1;
            this.radioButton_AnimationNo.TabStop = true;
            this.radioButton_AnimationNo.Text = "nein";
            this.radioButton_AnimationNo.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Draw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Canvas);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formen zeichnen mit GDI+ API";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Kreis;
        private System.Windows.Forms.RadioButton radioButton_Quadrat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar_Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_AnimationNo;
        private System.Windows.Forms.RadioButton radioButton_AnimationYes;
    }
}

