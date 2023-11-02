using System;

namespace GenericConstraintApp
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            RegDate = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime RegDate { get; set; }

    }
}
