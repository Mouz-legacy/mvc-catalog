using System.Collections.Generic;

namespace Web_953502_Strelets.Entities
{
    /// <summary>
    /// Class that describe car's group.
    /// </summary>
    public class CarGroup
    {
        /// <summary>
        /// Gets pr sets car group id.
        /// </summary>
        public int CarGroupId { get; set; }

        /// <summary>
        /// Gets or sets group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets list of cars.
        /// </summary>
        public List<Car> Cars { get; set; }
    }
}
