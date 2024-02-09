namespace testSkedgeApi.Dtos
{
    public class EntityLightClientDto
    {
        /// <summary>
        /// Id de l'entité
        /// Entity's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'entité
        /// Entity's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Adresse de l'entité
        /// Entity's address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ville de l'entité
        /// Entity's town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Siren de l'entité
        /// Entity's SIREN
        /// </summary>
        public string SIREN { get; set; }

        /// <summary>
        /// Code interne de l'entité
        /// Entity's internal code
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// ISIN de l'entité
        /// Entity's ISIN
        /// </summary>
        public string ISIN { get; set; }

        /// <summary>
        /// Code NAF de l'entité
        /// Entity's NAF code
        /// </summary>
        public string NAF { get; set; }

        /// <summary>
        /// RCS de l'entité
        /// Entity's RCS
        /// </summary>
        public string RCS { get; set; }

        /// <summary>
        /// Code LEI de l'entité
        /// Entity's LEI code
        /// </summary>
        public string LEI { get; set; }
    }
}
