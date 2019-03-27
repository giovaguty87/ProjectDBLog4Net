namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.richTxtBoxEmpleados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblResponse
            // 
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(12, 229);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(448, 38);
            this.lblResponse.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(374, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(374, 270);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(83, 38);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // richTxtBoxEmpleados
            // 
            this.richTxtBoxEmpleados.Location = new System.Drawing.Point(15, 12);
            this.richTxtBoxEmpleados.Name = "richTxtBoxEmpleados";
            this.richTxtBoxEmpleados.Size = new System.Drawing.Size(442, 214);
            this.richTxtBoxEmpleados.TabIndex = 12;
            this.richTxtBoxEmpleados.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 363);
            this.Controls.Add(this.richTxtBoxEmpleados);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblResponse);
            this.Name = "Form1";
            this.Text = "MainFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RichTextBox richTxtBoxEmpleados;
    }
}

