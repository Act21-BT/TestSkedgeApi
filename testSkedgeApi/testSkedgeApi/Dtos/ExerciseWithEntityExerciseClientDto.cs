namespace testSkedgeApi.Dtos
{
    public class ExerciseWithEntityExerciseClientDto
    {
        /// <summary>
        /// Id de l'exercice
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'exercice
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description de l'exercice
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Statut de l'exercice
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Nom de l'organisme de l'exercice
        /// </summary>
        public string OrganismName { get; set; }

        /// <summary>
        /// Nom du référentiel de l'exercice
        /// </summary>
        public string RepositoryDefinitionName { get; set; }

        /// <summary>
        /// Méthode de collecte de l'exercice
        /// </summary>
        public string PatternName { get; set; }

        /// <summary>
        /// Périodicité de l'exercice
        /// </summary>
        public string Periodicity { get; set; }

        /// <summary>
        /// Date de l'exercice
        /// </summary>
        public DateTime ApplicableDate { get; set; }

        /// <summary>
        /// Groupe de comparaison de l'exercice
        /// </summary>
        public string ComparaisonGroupName { get; set; }

        /// <summary>
        /// Groupe d'entité de comparaison de l'exercice
        /// </summary>
        public string EntityComparaisonGroupName { get; set; }

        /// <summary>
        /// Score statique de l'exercice
        /// </summary>
        public string StaticScoringName { get; set; }

        /// <summary>
        /// Filtrer par catégorie
        /// </summary>
        public bool? FilterByCategory { get; set; }

        /// <summary>
        /// Filtrer par secteur d'activité
        /// </summary>
        public bool? FilterByActivitySector { get; set; }

        /// <summary>
        /// Filtrer par participation majoritaire
        /// </summary>
        public bool? FilterByMajorityStake { get; set; }

        /// <summary>
        /// Pourcentage de participation minimal
        /// </summary>
        public double? MinParticipationPercentage { get; set; }

        /// <summary>
        /// Nombre d'années précédentes
        /// </summary>
        public int? HistoricYearsNumber { get; set; }

        /// <summary>
        /// Exercices d'entité de l'exercice
        /// </summary>
        public IEnumerable<EntityExerciseClientDto> EntityExercises { get; set; }

        /// <summary>
        /// Territoire de l'exercice
        /// </summary>
        public string TerritoryName { get; set; }
    }
}
