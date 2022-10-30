using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionSencilla.Entidades
{
    public class Enums
    {
        public enum CodigoRespuesta
        {
            [Description("OK")]
            OK = 200,

            [Description("Bad Request")]
            BadRequest = 400,

            [Description("Unauthorized")]
            Unauthorized = 401,

            [Description("Not Found")]
            NotFound = 404,

            [Description("Invalid ")]
            InvalidStatus = 406,

            [Description("Time out")]
            RequestTimeout = 408,

            [Description("Internal Server Error")]
            InternalServiceError = 500,

            [Description("Not Implemented")]
            NotImplemented = 501
        }
    }
}
