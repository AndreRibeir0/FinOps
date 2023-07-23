namespace FinOps.Model
{
    public class Entity
    {
        protected Entity()
        {

        }

        public Guid Id { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}