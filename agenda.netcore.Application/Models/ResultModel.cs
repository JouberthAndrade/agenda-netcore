using Microsoft.Extensions.Logging;

namespace agenda.netcore.Application.Models
{
	public class ResultModel
	{
		public ResultModel() { }
        public ResultModel(string message, int statusCode, LogLevel log)
        {
            Message = message;
            StatusCode = statusCode;
            LogLevel = log;
        }
        
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public LogLevel LogLevel { get; set; }
        
    }
}
