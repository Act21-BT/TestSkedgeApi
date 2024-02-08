namespace testSkedgeApi.Dtos
{
    public class EntityLightClientDto
    {
        /// <summary>
        /// Id de l'entité
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'entité
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Adresse de l'entité
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ville de l'entité
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Siren de l'entité
        /// </summary>
        public string SIREN { get; set; }

        /// <summary>
        /// Code interne de l'entité
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// ISIN de l'entité
        /// </summary>
        public string ISIN { get; set; }

        /// <summary>
        /// Code NAF de l'entité
        /// </summary>
        public string NAF { get; set; }

        /// <summary>
        /// RCS de l'entité
        /// </summary>
        public string RCS { get; set; }


        /// <summary>
        /// Code LEI de l'entité
        /// </summary>
        public string LEI { get; set; }
    }
}
