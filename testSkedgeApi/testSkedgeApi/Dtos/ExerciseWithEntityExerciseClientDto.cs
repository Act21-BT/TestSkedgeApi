namespace testSkedgeApi.Dtos
{
    public class ExerciseWithEntityExerciseClientDto
    {
        /// <summary>
        /// Id de l'exercice
        /// Exercise's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'exercice
        /// Exercise's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description de l'exercice
        /// Exercise's description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Statut de l'exercice
        /// Exercise's status
        /// </summary>
        public ExerciseState? Status { get; set; }

        /// <summary>
        /// Nom de l'organisme de l'exercice
        /// Organism's name of the exercise
        /// </summary>
        public string OrganismName { get; set; }

        /// <summary>
        /// Nom du référentiel de l'exercice
        /// Repository's name of the exercise
        /// </summary>
        public string RepositoryDefinitionName { get; set; }

        /// <summary>
        /// Méthode de collecte de l'exercice
        /// Collection method of the exercise
        /// </summary>
        public string PatternName { get; set; }

        /// <summary>
        /// Périodicité de l'exercice
        /// Periodicity of the exercise
        /// </summary>
        public Periodicity? Periodicity { get; set; }

        /// <summary>
        /// Date de l'exercice
        /// Date of the exercise
        /// </summary>
        public DateTime ApplicableDate { get; set; }

        /// <summary>
        /// Groupe de comparaison de l'exercice
        /// Comparison group of the exercise
        /// </summary>
        public string ComparaisonGroupName { get; set; }

        /// <summary>
        /// Groupe d'entité de comparaison de l'exercice
        /// Entity comparison group of the exercise
        /// </summary>
        public string EntityComparaisonGroupName { get; set; }

        /// <summary>
        /// Score statique de l'exercice
        /// Static score of the exercise
        /// </summary>
        public string StaticScoringName { get; set; }

        /// <summary>
        /// Filtrer par catégorie
        /// Filter by category
        /// </summary>
        public bool? FilterByCategory { get; set; }

        /// <summary>
        /// Filtrer par secteur d'activité
        /// Filter by activity sector
        /// </summary>
        public bool? FilterByActivitySector { get; set; }

        /// <summary>
        /// Filtrer par participation majoritaire
        /// Filter by majority stake
        /// </summary>
        public bool? FilterByMajorityStake { get; set; }

        /// <summary>
        /// Pourcentage de participation minimal
        /// Minimum participation percentage
        /// </summary>
        public double? MinParticipationPercentage { get; set; }

        /// <summary>
        /// Nombre d'années précédentes
        /// Number of previous years
        /// </summary>
        public int? HistoricYearsNumber { get; set; }

        /// <summary>
        /// Exercices d'entité de l'exercice
        /// Entity exercises of the exercise
        /// </summary>
        public IEnumerable<EntityExerciseClientDto> EntityExercises { get; set; }

        /// <summary>
        /// Territoire de l'exercice
        /// Exercise's territory name
        /// </summary>
        public string TerritoryName { get; set; }
    }
}
