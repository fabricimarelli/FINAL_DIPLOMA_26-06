using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using MODELO;


namespace VISTA
{
    public partial class frmPronostico : Form
    {

        public frmPronostico()
        {
            InitializeComponent();
            ObtenerPronostico();
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerPronostico();
        }

        
        private void ObtenerPronostico()
        {
            
            
            string path = @"C:\Users\fabri\OneDrive\Cursada 2022\2do cuatrimestre\Trabajo de diploma\Proyecto de Diploma\API_KEY.txt";
            string Apikey = File.ReadAllText(path);//Leo la API key desde un txt para no declararla dentro del codigo por temas de seguridad (este codigo esta en repositorio publico)
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=es", txtCiudad.Text, Apikey);
                //var json = web.DownloadString(url);
                var json = "";
                try {  json = web.DownloadString(url); }
                catch(Exception ex) { 
                    MessageBox.Show(ex.Message+" Verifique el nombre de la localidad");
                    return;
                };
                Pronostico.root info = JsonConvert.DeserializeObject<Pronostico.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                //lblCondicion.Text = info.weather[0].main;
                lblLocalidad.Text = char.ToUpper(info.name[0]) + info.name.Substring(1);
                lblDetalles.Text = char.ToUpper(info.weather[0].description[0]) + info.weather[0].description.Substring(1);
                lblAtardecer.Text = convertDateTime(info.sys.sunset).ToShortTimeString();
                lblAmanecer.Text = convertDateTime(info.sys.sunrise).ToShortTimeString(); 
                lblVelViento.Text = info.wind.speed.ToString()+"m/s";
                lblTermica.Text = info.main.feels_like.ToString()+"°C";
                lblPresion.Text = info.main.pressure.ToString()+"hPa";
                lblTemperatura.Text = info.main.temp.ToString()+"°C";
                lblHumedad.Text=info.main.humidity.ToString()+"%";
                lblNubes.Text = info.clouds.all.ToString() + "%";
                lblLon.Text = info.coord.lon.ToString()+"°";
                lblLat.Text = info.coord.lat.ToString()+"°";
                
                int dirViento = info.wind.deg;
                string card="";
                if (dirViento > 345 || dirViento <= 15)
                    card = "NORTE";
                else if (dirViento > 15 && dirViento <= 75)
                    card = "NORESTE";
                else if (dirViento > 75 && dirViento <= 105)
                    card = "ESTE";
                else if (dirViento > 105 && dirViento <= 165)
                    card = "SURESTE";
                else if (dirViento > 165 && dirViento <= 195)
                    card = "SUR";
                else if (dirViento > 195 && dirViento <= 255)
                    card = "SUROESTE";
                else if (dirViento > 255 && dirViento <= 285)
                    card = "OESTE";
                else if (dirViento > 285 && dirViento <= 345)
                    card = "NOROESTE";

                lblDirecViento.Text = info.wind.deg.ToString() + "° "+card;



            }

        }

        DateTime convertDateTime(long milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisec).ToLocalTime();
            return day;
        }

       

    }
}
