using System.Text.Json;

namespace AS2425._4G.MouniriYousef.Meteo
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Temperatura> cacheMeteo = new();
        Temperature temperature = new Temperature();

        public Form1()
        {
            InitializeComponent();
            CaricaColonneDataGridView();
        }

        private void CaricaColonneDataGridView()
        {
            dgvMeteo.Columns.Add("Città", "Città");
            dgvMeteo.Columns.Add("Descrizione", "Descrizione");
            dgvMeteo.Columns.Add("Emoji", "Emoji");
            dgvMeteo.Columns.Add("GradiCelsius", "Gradi °C");
            dgvMeteo.Columns.Add("IconUrl", "Icona");

            dgvMeteo.Columns["IconUrl"].Visible = false;
        }

        private void AggiornaDataGridView()
        {
            // Svuota tutte le righe esistenti nel DataGridView
            dgvMeteo.Rows.Clear();

            // Itera attraverso la lista di temperature e aggiunge ogni elemento al DataGridView
            foreach (Temperatura temperatura in temperature.ViewTemperature())
            {
                dgvMeteo.Rows.Add(
                    temperatura.Città,
                    temperatura.Descrizione,
                    temperatura.Emoji,
                    temperatura.GradiCelsius,
                    temperatura.IconUrl
                );
            }
        }



        private async void btnCerca_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            if (string.IsNullOrWhiteSpace(city)) return;

            string cityKey = city.ToLower();

            if (cacheMeteo.TryGetValue(cityKey, out var temperaturaCached))
            {
                if (temperaturaCached.IsExpired())
                {
                    return;
                }
                else
                {
                    cacheMeteo.Remove(cityKey);
                }
            }

        }

        private void dgvMeteo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? url = dgvMeteo.Rows[e.RowIndex].Cells["IconUrl"].Value?.ToString();
                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        //picImage.Load(url);
                    }
                    catch
                    {
                        // gestione errore caricamento immagine
                    }
                }
            }
        }

        private string getIconUrlFromDescription(string desc)
        {
            desc = desc.ToLower();
            if (desc.Contains("cloud")) return "https://cdn-icons-png.flaticon.com/512/1163/1163624.png";
            if (desc.Contains("rain")) return "https://cdn-icons-png.flaticon.com/512/1163/1163657.png";
            if (desc.Contains("clear")) return "https://cdn-icons-png.flaticon.com/512/869/869869.png";
            if (desc.Contains("snow")) return "https://cdn-icons-png.flaticon.com/512/1176/1176685.png";
            return "https://cdn-icons-png.flaticon.com/512/1163/1163657.png"; // default icona
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            foreach (var t in temperature.ViewTemperature())
            {

                AggiornaDataGridView();

            }
        }

        private void btnAggiungiPrenotazione_Click(object sender, EventArgs e)
        {
            string città = txtCity.Text;
            string orario = txtOrario.Text;
            string data = txtData.Text;

            Temperatura temperatura = new Temperatura
            {
                Città = città,
                Orario = orario,
                Data = data,
            };

            temperature.AddTemperature(temperatura);
        }
    }
}
