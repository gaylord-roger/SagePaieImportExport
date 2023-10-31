using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// GT
    /// </summary>
    [FixedLengthFile]
    public class DonneesPageTemps
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "GT";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [EnumField(3)]
        public Civilite Civilite { get; set; }

        [StringField(4, 30)]
        public string Nom { get; set; }

        [StringField(5, 20)]
        public string Prenom { get; set; }

        [StringField(6, 5)]
        public string Etablissement { get; set; }

        [DateField(7)]
        public DateTime? DernierEnregistrementEvementsStandards { get; set; }

        [DateField(8)]
        public DateTime? DernierEnregistrementHeuresSupplementaires { get; set; }

        [DateField(9)]
        public DateTime? DernierEnregistrementReposCompensateur { get; set; }

        [DateField(10)]
        public DateTime? DernierEnregistrementEvenementsGénérés { get; set; }

        [DecimalField(11, 10)]
        public decimal? HeuresSupplementairesEnCours { get; set; }

        [DecimalField(12, 10)]
        public decimal? HeuresSupplementairesApresEnregistrement { get; set; }

        [DecimalField(13, 10)]
        public decimal? SoldeReposCompensateurEnCours { get; set; }

        [DecimalField(14, 10)]
        public decimal? SoldeReposCompensateurApresEnregistrement { get; set; }

        [DecimalField(15, 10)]
        public decimal? CumulDuReposCompensateur { get; set; }
    }
}
