namespace CommandAPI.Models
{
    public class Command
    {
        public int CommandId { get; set; }
        public string Instrucction { get; set; }
        public string? Description { get; set; } 
        public DateTime? CreatedAt { get; set; }
        
    }
}