using APIs.ViewModels;
using APIs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Api2Controller : ControllerBase
    {
        [HttpGet]
        [Route("CalculaJuros")]
        public IActionResult CalculaJuros(decimal valorInicial, int tempo)
        {
            //return Ok(Juros.CalcularJuros(valorInicial, tempo, 0.01M));
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44371/api/api1/");
                    var responseTask = client.GetAsync("taxajuros");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var taxaJuros = JsonConvert.DeserializeObject<Decimal>(readTask.Result);

                        return Ok(Juros.CalcularJuros(valorInicial, tempo, taxaJuros));
                    }
                    else
                    {
                        return Problem();
                    }
                }
            }
            catch (Exception ex)
            {
                return Problem();
            }

        }

    }
}
