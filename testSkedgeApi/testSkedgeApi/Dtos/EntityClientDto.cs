namespace testSkedgeApi.Dtos
{
    public class EntityClientDto
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
        /// Souscription de l'entité
        /// </summary>
        public string SubscriptionStateName { get; set; }

        /// <summary>
        /// Statut de l'entité
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// Adresse de l'entité
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Complément d'adresse de l'entité
        /// </summary>
        public string AddressComplement { get; set; }

        /// <summary>
        /// Code postal de l'entité
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Ville de l'entité
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Pays de l'entité
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Site internet de l'entité
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// Raison social de l'entité
        /// </summary>
        public string CorporateName { get; set; }

        /// <summary>
        /// Forme juridique de l'entité
        /// </summary>
        public string LegalStatusName { get; set; }

        /// <summary>
        /// Siren de l'entité
        /// </summary>
        public string SIREN { get; set; }

        /// <summary>
        /// Date de souscription de l'entité
        /// </summary>
        public DateTime? SubscriptionDate { get; set; }

        /// <summary>
        /// Echéance de la souscription de l'entité
        /// </summary>
        public DateTime? SubscriptionDeadline { get; set; }

        /// <summary>
        /// Type de l'entité
        /// </summary>
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Entité parente de l'entité
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// Secteur d'activité de l'entité
        /// </summary>
        public string ActivitySectorName { get; set; }

        /// <summary>
        /// Code NACE de l'entité
        /// </summary>
        public string NaceCodeName { get; set; }

        /// <summary>
        /// Classe de l'entité
        /// </summary>
        public string EntityClassName { get; set; }

        /// <summary>
        /// Effectif de l'entité
        /// </summary>
        public int? Workforce { get; set; }

        /// <summary>
        /// Secteur géographique de l'entité
        /// </summary>
        public string GeographicSectorName { get; set; }

        /// <summary>
        /// Chiffre d'affaire de l'entité
        /// </summary>
        public decimal? Turnover { get; set; }

        /// <summary>
        /// Code interne de l'entité
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// Nom du référent
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Email du référent
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Numéro de téléphone du référent
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// ISIN de l'entité
        /// </summary>
        public string ISIN { get; set; }

        /// <summary>
        /// Code NAF de l'entité
        /// </summary>
        public string NAF { get; set; }

        /// <summary>
        /// Bloomberg de l'entité
        /// </summary>
        public string Bloomberg { get; set; }

        /// <summary>
        /// RCS de l'entité
        /// </summary>
        public string RCS { get; set; }

        /// <summary>
        /// AMF de l'entité
        /// </summary>
        public string AMF { get; set; }

        /// <summary>
        /// Code LEI de l'entité
        /// </summary>
        public string LEI { get; set; }

        /// <summary>
        /// programme (opération) l'entité
        /// </summary>
        public string EntityCategoryName { get; set; }

        /// <summary>
        /// Date de début d’activité (opération) de l'entité
        /// </summary>
        public DateTime? ActivityDateStart { get; set; }

        /// <summary>
        /// Date de fin d’activité (opération) de l'entité
        /// </summary>
        public DateTime? ActivityDateEnd { get; set; }

        /// <summary>
        /// Liste des noms des groupes de comparaison de l'entité
        /// </summary>
        public IEnumerable<string> EntityGroups { get; set; }
    }
}
