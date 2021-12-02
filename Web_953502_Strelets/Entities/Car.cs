namespace Web_953502_Strelets.Entities
{
    /// <summary>
    /// Describe a car entity.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets car id.
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Gets or sets car mark.
        /// </summary>
        public string Mark { get; set; }

        /// <summary>
        /// Gets or sets model of car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets car's image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets car's color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets car group id.
        /// </summary>
        public int CarGroupId { get; set; }

        /// <summary>
        /// Gets or sets car group.
        /// </summary>
        public CarGroup Group { get; set; }
    }
}
