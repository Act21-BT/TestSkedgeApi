namespace testSkedgeApi.Dtos
{
    #region entityEnums
    public enum SubscriptionState
    {
        FREE = 0,
        PAID = 1,
        LATE = 2,
        SUSPENDED = 3,
        CLOSED = 4,
        BLOCKED = 5,
        WAITING = 6
    }

    public enum InscriptionStatus
    {
        IN_PROGRESS = 0,
        VALIDATED = 1,
        REFUSED = 2,
        DEACTIVATED = 3,
        IN_INSCRIPTION_PROGRESS = 4
    }

    #endregion

    #region exerciseEnumes

    public enum ExerciseState
    {
        /// <summary>
        /// Brouillon
        /// </summary>
        DRAFT = 0,
        /// <summary>
        /// En cours
        /// </summary>
        IN_PROGRESS = 1,
        /// <summary>
        /// Terminé
        /// </summary>
        CLOSED = 2,
        /// <summary>
        /// En attente
        /// </summary>
        AWAITING = 3,
        /// <summary>
        /// Archivé
        /// </summary>
        ARCHIVED = 4,
    }

    public enum Periodicity
    {
        /// <summary>
        /// Inconnu
        /// </summary>
        UNKNOWN = 0,
        /// <summary>
        /// Bisannuel, signifie tous les deux ans ou qui dure deux ans
        /// </summary>
        BIENNIAL = 1,
        /// <summary>
        /// Annuelle
        /// </summary>
        ANNUAL = 2,
        /// <summary>
        /// Semestriel
        /// </summary>
        BIANNUAL = 3,
        /// <summary>
        /// Trimestriel
        /// </summary>
        QUARTERLY = 4,
        /// <summary>
        /// Mensuel
        /// </summary>
        MONTHLY = 5,
        /// <summary>
        /// Hebdomadaire
        /// </summary>
        WEEKLY = 6
    }

    #endregion

    #region entityExerciseEnums
    public enum EntityExerciseStatus
    {
        AWAITING = 0,
        IN_PROGRESS = 1,
        DONE = 2
    }
    #endregion
}
