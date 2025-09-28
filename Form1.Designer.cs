namespace Arbol_AVL
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            valor = new TextBox();
            BtnIngresar = new Button();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            BtnSalir = new Button();
            pre = new RadioButton();
            ino = new RadioButton();
            post = new RadioButton();
            label2 = new Label();
            errores = new ErrorProvider(components);
            lblaltura = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(794, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 0;
            label1.Text = "Altura del Arbol:";
            label1.Click += label1_Click;
            // 
            // valor
            // 
            valor.Location = new Point(817, 145);
            valor.Margin = new Padding(2, 1, 2, 1);
            valor.Name = "valor";
            valor.Size = new Size(113, 23);
            valor.TabIndex = 1;
            valor.Tag = "valor";
            // 
            // BtnIngresar
            // 
            BtnIngresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIngresar.Location = new Point(817, 172);
            BtnIngresar.Margin = new Padding(2, 1, 2, 1);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(111, 22);
            BtnIngresar.TabIndex = 2;
            BtnIngresar.Text = "Agregar Dato";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(817, 204);
            BtnBuscar.Margin = new Padding(2, 1, 2, 1);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(111, 22);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "Buscar Dato";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(817, 234);
            BtnEliminar.Margin = new Padding(2, 1, 2, 1);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(111, 22);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar Dato";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.Location = new Point(817, 263);
            BtnSalir.Margin = new Padding(2, 1, 2, 1);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(111, 22);
            BtnSalir.TabIndex = 5;
            BtnSalir.Tag = "BtnSalir";
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // pre
            // 
            pre.AutoSize = true;
            pre.Location = new Point(127, 357);
            pre.Margin = new Padding(2, 1, 2, 1);
            pre.Name = "pre";
            pre.Size = new Size(78, 19);
            pre.TabIndex = 6;
            pre.TabStop = true;
            pre.Text = "Pre Orden";
            pre.UseVisualStyleBackColor = true;
            pre.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // ino
            // 
            ino.AutoSize = true;
            ino.Location = new Point(337, 357);
            ino.Margin = new Padding(2, 1, 2, 1);
            ino.Name = "ino";
            ino.Size = new Size(74, 19);
            ino.TabIndex = 7;
            ino.TabStop = true;
            ino.Text = "En Orden";
            ino.UseVisualStyleBackColor = true;
            // 
            // post
            // 
            post.AutoSize = true;
            post.Location = new Point(540, 357);
            post.Margin = new Padding(2, 1, 2, 1);
            post.Name = "post";
            post.Size = new Size(84, 19);
            post.TabIndex = 8;
            post.TabStop = true;
            post.Text = "Post Orden";
            post.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(829, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 9;
            label2.Text = "Opciones";
            // 
            // errores
            // 
            errores.ContainerControl = this;
            errores.Tag = "valor";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaltura.ForeColor = SystemColors.ButtonHighlight;
            lblaltura.Location = new Point(911, 11);
            lblaltura.Margin = new Padding(2, 0, 2, 0);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(18, 20);
            lblaltura.TabIndex = 10;
            lblaltura.Text = "#";
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 12);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(27, 336);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1064, 503);
            Controls.Add(panel1);
            Controls.Add(lblaltura);
            Controls.Add(label2);
            Controls.Add(post);
            Controls.Add(ino);
            Controls.Add(pre);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnIngresar);
            Controls.Add(valor);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)errores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox valor;
        private Button BtnIngresar;
        private Button BtnBuscar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private RadioButton pre;
        private RadioButton ino;
        private RadioButton post;
        private Label label2;
        private ErrorProvider errores;
        private Label lblaltura;
        private Panel panel1;
    }
}
