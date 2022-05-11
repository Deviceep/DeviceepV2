using Deviceep.API.IoTFunctions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QrController : Controller
    {
       
        [HttpGet(Name = "GetQRCoder")]
        // Possible Responses from the function

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Gets a specific Attendance according to the id it has been given
        public async Task<IActionResult> GetQRCoder(string a)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(a, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(23, Color.Black, Color.White, false);
            //var attendance = await _attendanceService.GetByIdAsync(id);
            // var result = _mapper.Map<AttendanceDTO>(attendance);
            qrFunctions qrFuncs = new qrFunctions();
            var bytes = qrFuncs.ImageToByteArray(qrCodeImage);
            return File(bytes, "image/bmp");
        }
        //Controls if the user has the right verifications to use this function
        //Checks the role as well
    }
}
