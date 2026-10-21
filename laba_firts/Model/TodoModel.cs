using System;

namespace laba_firts.Model
{
    public class TodoModel
    {
        private string iname = string.Empty;

        public Guid Id { get; set; } = Guid.NewGuid();

        public string name
        {
            get { return iname; }
            set
            {
                if (value == null)
                    throw new ArgumentException("название не может быть пустым");
                iname = value;
            }
        }
        public string opis { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(1);
        public Prioritet Priority { get; set; } = Prioritet.med;
        public Status Status { get; set; } = Status.notstart;
    }
}
