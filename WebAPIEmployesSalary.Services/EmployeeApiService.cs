using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebAPIEmployesSalary.Services
{   
    public class EmployeeApiService
    {
        private readonly HttpClient _httpClient;

        public EmployeeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> ObtenerDatosAsync<T>(string url)
        {

            try
            {
                return await _httpClient.GetFromJsonAsync<T>(url);
            }
            catch (HttpRequestException ex)
            {
                // Manejo de errores de solicitud HTTP
                // Log para saber el error o lanzar una excepción personalizada
                throw new Exception("Error al consultar la API: " + ex.Message, ex);
            }
            catch (NotSupportedException ex)
            {
                // Manejo de errores si el contenido no es JSON
                throw new Exception("El formato de respuesta no es compatible: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Manejo de otros errores
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }

            return await _httpClient.GetFromJsonAsync<T>(url);
        }
    }

}
