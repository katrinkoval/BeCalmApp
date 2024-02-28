

namespace BeCalm.Core.Entities
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Therapist> Therapists { get; set; }
    }
}
