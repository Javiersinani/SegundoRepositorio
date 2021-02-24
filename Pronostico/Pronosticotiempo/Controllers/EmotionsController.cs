﻿namespace Pronosticotiempo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pronosticotiempo.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class EmotionsController : ControllerBase
    {
        [HttpGet]
        [Route("conNumero")]
        public string Emocion(int suerte)
        {
            if (suerte == 0)
                return "Sos una persona indiferente";
            if (suerte == 1)
                return "sos una persona feliz";
            if (suerte == 3)
                return "sos una persona aburrida";
            return "estoy muy ocupado, no te puedo atender en este momento";

        }
        [HttpPost]
        [Route("conNumero")]
        public string Emocion2([FromHeader] int suerte)
        {
            if (suerte == 0)
                return "Sos una persona indiferente";
            if (suerte == 1)
                return "sos una persona feliz";
            if (suerte == 3)
                return "sos una persona aburrida";
            return "estoy muy ocupado, no te puedo atender en este momento";

        }
        [HttpPost]
        [Route("ConModelo")]
        public string Emocion3([FromBody] Luck luck)
        {
            if (luck.LuckId == 0)
                return "Sos una persona indiferente";
            if (luck.LuckId == 1)
                return "sos una persona feliz";
            if (luck.LuckId == 3)
                return "sos una persona aburrida";
            return "estoy muy ocupado, no te puedo atender en este momento";
        }
    }
}
