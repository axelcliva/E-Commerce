namespace E_Commerce
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
            lista_prodotti = new ListBox();
            lista_carrello = new ListBox();
            label_info = new Label();
            label_prezzo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lista_prodotti
            // 
            lista_prodotti.FormattingEnabled = true;
            lista_prodotti.ItemHeight = 15;
            lista_prodotti.Location = new Point(48, 52);
            lista_prodotti.Name = "lista_prodotti";
            lista_prodotti.Size = new Size(115, 94);
            lista_prodotti.TabIndex = 0;
            lista_prodotti.SelectedIndexChanged += lista_prodotti_SelectedIndexChanged;
            // 
            // lista_carrello
            // 
            lista_carrello.FormattingEnabled = true;
            lista_carrello.ItemHeight = 15;
            lista_carrello.Location = new Point(48, 188);
            lista_carrello.Name = "lista_carrello";
            lista_carrello.Size = new Size(115, 94);
            lista_carrello.TabIndex = 1;
            lista_carrello.SelectedIndexChanged += lista_carrello_SelectedIndexChanged;
            // 
            // label_info
            // 
            label_info.AutoSize = true;
            label_info.Location = new Point(249, 57);
            label_info.Name = "label_info";
            label_info.Size = new Size(130, 15);
            label_info.TabIndex = 2;
            label_info.Text = "Informazioni Prodotto: ";
            // 
            // label_prezzo
            // 
            label_prezzo.AutoSize = true;
            label_prezzo.Location = new Point(440, 57);
            label_prezzo.Name = "label_prezzo";
            label_prezzo.Size = new Size(81, 15);
            label_prezzo.TabIndex = 3;
            label_prezzo.Text = "Prezzo Totale: ";
            // 
            // button1
            // 
            button1.Location = new Point(249, 202);
            button1.Name = "button1";
            button1.Size = new Size(80, 42);
            button1.TabIndex = 4;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 202);
            button2.Name = "button2";
            button2.Size = new Size(80, 42);
            button2.TabIndex = 5;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(440, 202);
            button3.Name = "button3";
            button3.Size = new Size(80, 42);
            button3.TabIndex = 6;
            button3.Text = "SVUOTA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_prezzo);
            Controls.Add(label_info);
            Controls.Add(lista_carrello);
            Controls.Add(lista_prodotti);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista_prodotti;
        private ListBox lista_carrello;
        private Label label_info;
        private Label label_prezzo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}