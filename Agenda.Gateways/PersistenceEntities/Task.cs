using System.ComponentModel.DataAnnotations;

namespace Agenda.Gateways.PersistenceEntities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
