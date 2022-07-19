using laboratorio.portal.Helper;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace laboratorio.portal.Services
{


    public interface IComunicator
    {
        Task<MapperResponse> Post(string controller, string method, object contentObject);
        Task<bool> PostBool(string controller, string method, object contentObject);
        Task<T> Get<T>(string controller, string method);

    }


    public class Communicator : StringHandler, IComunicator
    {

        private readonly HttpClient _clientHttp;

        public Communicator()
        {
            _clientHttp = new HttpClient();
        }

        public async Task<T> Get<T>(string controller, string method)
        {
            try
            {
                string command = IntanceOperador(controller, method);

                var responseRequestGet = await _clientHttp.GetAsync(command);
                var jaja = await responseRequestGet.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<T>(await responseRequestGet.Content.ReadAsStringAsync());

                return response;
            }
            catch (Exception)
            {
                return default;
            }
            finally
            {
                _clientHttp.Dispose();
            }
        }

        public async Task<MapperResponse> Post(string controller, string method, object contentObject)
        {
            try
            {
                string command = IntanceOperador(controller, method);

                var response = await _clientHttp.PostAsJsonAsync(command, contentObject);
                var responseMapper = JsonConvert.DeserializeObject<MapperResponse>(await response.Content.ReadAsStringAsync());

                return responseMapper;
            }
            catch (Exception)
            {
                return new MapperResponse();
            }
            finally
            {
                _clientHttp.Dispose();
            }
        }

        public async Task<bool> PostBool(string controller, string method, object contentObject)
        {
            try
            {
                string command = IntanceOperador(controller, method);

                var response = await _clientHttp.PostAsJsonAsync(command, contentObject);

                return response.StatusCode.Equals(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _clientHttp.Dispose();
            }
        }
    }
}
