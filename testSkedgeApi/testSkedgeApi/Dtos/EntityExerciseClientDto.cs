namespace testSkedgeApi.Dtos
{
    public class EntityExerciseClientDto
    {

        /// <summary>
        /// Id de l'exercice d'entité
        /// Entity exercise's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'exercice d'entité
        /// Entity exercise's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Etat de l'exercice d'entité
        /// Entity exercise's state
        /// </summary>
        public EntityExerciseStatus EntityExerciseStateName { get; set; }

        /// <summary>
        /// Etape en cours de l'exercice d'entité
        /// Current step of the entity exercise
        /// </summary>
        public string CurrentStepName { get; set; }
    }
}
