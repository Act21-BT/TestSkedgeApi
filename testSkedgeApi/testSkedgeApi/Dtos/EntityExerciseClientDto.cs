namespace testSkedgeApi.Dtos
{
    public class EntityExerciseClientDto
    {

        /// <summary>
        /// Id de l'exercice d'entité
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'exercice d'entité
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Etat de l'exercice d'entité
        /// </summary>
        public string EntityExerciseStateName { get; set; }

        /// <summary>
        /// Etape en cours de l'exercice d'entité
        /// </summary>
        public string CurrentStepName { get; set; }
    }
}
