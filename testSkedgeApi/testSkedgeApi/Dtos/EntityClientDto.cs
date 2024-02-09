namespace testSkedgeApi.Dtos
{
    public class EntityClientDto
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
        /// Souscription de l'entité
        /// Entity's subscription state
        /// </summary>
        public SubscriptionState SubscriptionState { get; set; }

        /// <summary>
        /// Statut de l'entité
        /// Entity's status
        /// </summary>
        public InscriptionStatus? Status { get; set; }

        /// <summary>
        /// Adresse de l'entité
        /// Entity's address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Complément d'adresse de l'entité
        /// Additional address information of the entity
        /// </summary>
        public string AddressComplement { get; set; }

        /// <summary>
        /// Code postal de l'entité
        /// Entity's postal code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Ville de l'entité
        /// Entity's town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Pays de l'entité
        /// Entity's country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Site internet de l'entité
        /// Entity's website
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// Raison social de l'entité
        /// Entity's corporate name
        /// </summary>
        public string CorporateName { get; set; }

        /// <summary>
        /// Forme juridique de l'entité
        /// Entity's legal status
        /// </summary>
        public string LegalStatusName { get; set; }

        /// <summary>
        /// Siren de l'entité
        /// Entity's SIREN
        /// </summary>
        public string SIREN { get; set; }

        /// <summary>
        /// Date de souscription de l'entité
        /// Entity's subscription date
        /// </summary>
        public DateTime? SubscriptionDate { get; set; }

        /// <summary>
        /// Echéance de la souscription de l'entité
        /// Entity's subscription deadline
        /// </summary>
        public DateTime? SubscriptionDeadline { get; set; }

        /// <summary>
        /// Type de l'entité
        /// Entity's type
        /// </summary>
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Entité parente de l'entité
        /// Parent entity of the entity
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// Secteur d'activité de l'entité
        /// Entity's activity sector
        /// </summary>
        public string ActivitySectorName { get; set; }

        /// <summary>
        /// Code NACE de l'entité
        /// Entity's NACE code
        /// </summary>
        public string NaceCodeName { get; set; }

        /// <summary>
        /// Classe de l'entité
        /// Entity's class
        /// </summary>
        public string EntityClassName { get; set; }

        /// <summary>
        /// Effectif de l'entité
        /// Entity's workforce
        /// </summary>
        public int? Workforce { get; set; }

        /// <summary>
        /// Secteur géographique de l'entité
        /// Entity's geographic sector
        /// </summary>
        public string GeographicSectorName { get; set; }

        /// <summary>
        /// Chiffre d'affaire de l'entité
        /// Entity's turnover
        /// </summary>
        public decimal? Turnover { get; set; }

        /// <summary>
        /// Code interne de l'entité
        /// Entity's internal code
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// Nom du référent
        /// Contact's name
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Email du référent
        /// Contact's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Numéro de téléphone du référent
        /// Contact's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

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
        /// Bloomberg de l'entité
        /// Entity's Bloomberg
        /// </summary>
        public string Bloomberg { get; set; }

        /// <summary>
        /// RCS de l'entité
        /// Entity's RCS
        /// </summary>
        public string RCS { get; set; }

        /// <summary>
        /// AMF de l'entité
        /// Entity's AMF
        /// </summary>
        public string AMF { get; set; }

        /// <summary>
        /// Code LEI de l'entité
        /// Entity's LEI code
        /// </summary>
        public string LEI { get; set; }

        /// <summary>
        /// programme (opération) l'entité
        /// Entity's program (operation)
        /// </summary>
        public string EntityCategoryName { get; set; }

        /// <summary>
        /// Date de début d’activité (opération) de l'entité
        /// Start date of the entity's activity (operation)
        /// </summary>
        public DateTime? ActivityDateStart { get; set; }

        /// <summary>
        /// Date de fin d’activité (opération) de l'entité
        /// End date of the entity's activity (operation)
        /// </summary>
        public DateTime? ActivityDateEnd { get; set; }

        /// <summary>
        /// Liste des noms des groupes de comparaison de l'entité
        /// List of the entity's comparison group names
        /// </summary>
        public IEnumerable<string> EntityGroups { get; set; }
    }
}
