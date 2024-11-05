using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProyectoCompany.Classes
{
    public class HttpRequests
    {
        // Crear una instancia global de HttpClient
        private static readonly HttpClient client = new HttpClient();
        static string apiBaseUrl = "http://localhost:5277/api/Usuarios";

        public async Task<List<User>> ObtenerUsuarios()
        {
            List<User> users = new List<User> { };
            HttpResponseMessage response = await client.GetAsync(apiBaseUrl); // Hacer la petición GET
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync(); // Leer la respuesta
                var usuarios = JsonConvert.DeserializeObject<List<User>>(json); // Convertir JSON a objeto
                foreach (var usuario in usuarios)
                {
                    users.Add(usuario);
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios en la base de datos");
            }
            return users;
        }

        public async Task<User> BuscarUsuarioPorEmail(string email)
        {
            string apiUrl2 = apiBaseUrl + "/email/" + email;
            HttpResponseMessage response = await client.GetAsync(apiUrl2);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var usuario = JsonConvert.DeserializeObject<User>(json);
                return usuario;
            }
            else
            {
                MessageBox.Show("Este email no corresponde a nuestra base de datos");
                return null;
            }
        }

        public async Task CrearUsuario(UserToSend nuevoUsuario)
        {
            string json = JsonConvert.SerializeObject(nuevoUsuario); // Convertir el objeto a JSON
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(apiBaseUrl, content); // Hacer la petición POST

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Se ha añadido");
            }
            else
            {
                MessageBox.Show("NO Se ha añadido" + response.ToString());
            }
        }

        public async Task ActualizarUsuario(UserToSend user, int id)
        {
            string json = JsonConvert.SerializeObject(user); // Convertir el objeto a JSON
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync($"{apiBaseUrl}/{id}", content); // Hacer la petición PUT
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Se ha modificado");
            }
            else
            {
                MessageBox.Show("Se ha añadido");
            }
        }

        public async Task EliminarUsuario(User user)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{apiBaseUrl}/{user.Id}"); // Hacer la petición DELETE
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Se ha eliminado");
            }
            else
            {
                MessageBox.Show("NO Se ha eliminado");
            }
        }
    }
}
