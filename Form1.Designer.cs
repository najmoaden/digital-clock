
namespace Digital_Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(99, 113);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(286, 110);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "10:10";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.Color.White;
            this.labelSecond.Location = new System.Drawing.Point(382, 166);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(62, 44);
            this.labelSecond.TabIndex = 1;
            this.labelSecond.Text = "10";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(98, 302);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(305, 57);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "May 29 2022";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(506, 302);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(190, 57);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Sunday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Timer timer;
    }
}

