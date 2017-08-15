using Microsoft.AspNetCore.Mvc;
using WorldNomads.Helpers;
using WorldNomads.ViewModels;

namespace WorldNomads.Controllers
{

    [Route("api/[controller]")]
    public class NumericSequenceController : Controller
    {
        [HttpGet("[action]")]
        public  ApiResponse<NumericSequenceResponse> GetNumericSequence(int number)
        {
            ApiResponse<NumericSequenceResponse> response = null;

            if (number <= 0)
            {
                response = new ApiResponse<NumericSequenceResponse>("Invalid number");
            }
            else
            {
                var numericSequenceResponse = NumericSequenceHelper.GenerateNumericSequence(number);
                response = new ApiResponse<NumericSequenceResponse>(numericSequenceResponse);
            }

            return response;
        }

       


    }
}


