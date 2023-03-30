using System;
namespace CV_Project.Models
{
	public class WriterMessageImageUrl
	{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string SenderName { get; set; }
        public string MessageContent { get; set; }
        public string ImageUrl { get; set; }
    }
}

