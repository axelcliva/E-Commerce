using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        private List<Prodotto> prodotti = new List<Prodotto>();
        private Carrello carrello = new Carrello("CARRELLO1");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prodotti.Add(new Prodotto("Volvo", "xc40", "01", 23000));
            prodotti.Add(new Prodotto("Audi", "cd41", "02", 40000));
            prodotti.Add(new Prodotto("Ferrari", "f1", "03", 123000));

            foreach (Prodotto prodotto in prodotti)
            {
                lista_prodotti.Items.Add($"{prodotto.Marca} , {prodotto.Modello} , €{prodotto.Prezzo}");
            }
        }

        private void lista_prodotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lista_prodotti.SelectedIndex;
            if (indice >= 0 && indice < prodotti.Count)
            {
                Prodotto prodotto = prodotti[indice];
                label_info.Text = $"Info Prodotto\nMarca: {prodotto.Marca}\nModello: {prodotto.Modello}\nPrezzo: €{prodotto.Prezzo}";
            }
        }

        private void lista_carrello_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lista_carrello.SelectedIndex;
            if (indice >= 0 && indice < carrello.ProdottiCarrello.Count)
            {
                Prodotto prodotto = carrello.ProdottiCarrello[indice];
                label_info.Text = $"Info Prodotto\nMarca: {prodotto.Marca}\nModello: {prodotto.Modello}\nPrezzo: €{prodotto.Prezzo}";
            }
        }
        private void AggiornaTot()
        {
            double tot = 0;
            foreach (Prodotto prodotto in carrello.ProdottiCarrello)
            {
                tot += prodotto.Prezzo;
            }
            label_prezzo.Text = $"Totale: €{tot:F2}";
        }
        private void button1_Click(object sender, EventArgs e) // BOTTONE AGGIUNGI
        {
            int indice = lista_prodotti.SelectedIndex;
            if (indice >= 0 && indice < prodotti.Count)
            {
                Prodotto prodotto = prodotti[indice];
                carrello.aggiungiProdotto(prodotto);
                lista_carrello.Items.Add($"{prodotto.Marca} {prodotto.Modello} - €{prodotto.Prezzo}");
                AggiornaTot();
            }
            else
            {
                MessageBox.Show("Devi prima selezionare un prodotto!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // BOTTONE RIMUOVI
        {
            int indice = lista_carrello.SelectedIndex;
            if (indice >= 0 && indice < carrello.ProdottiCarrello.Count)
            {
                Prodotto prodotto = carrello.ProdottiCarrello[indice];
                carrello.rimuoviProdotto(prodotto);
                lista_carrello.Items.RemoveAt(indice);
                AggiornaTot();
            }
            else
            {
                MessageBox.Show("Devi prima selezionare un prodotto!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // BOTTONE SVUOTA
        {
            carrello.svuotaCarrello();
            lista_carrello.Items.Clear();
            AggiornaTot();
        }
    }
}