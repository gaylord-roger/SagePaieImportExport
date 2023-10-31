using System;
using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;

namespace SagePaieImportExport
{
    /// <summary>
    /// 04
    /// </summary>
    [FixedLengthFile]
    public class DonneesAffectation
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "04";

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

        [StringField(7, 3)]
        public int? ConventionCollective { get; set; }

        [StringField(8, 10)]
        public int? Departement { get; set; }

        [StringField(9, 10)]
        public int? Service { get; set; }

        [StringField(10, 10)]
        public int? Unite { get; set; }

        [StringField(11, 10)]
        public int? Categorie { get; set; }

        [StringField(12, 30)]
        public string EmploiOccupe { get; set; }

        // 142
        [StringField(13, 10)]
        public string Indice { get; set; }

        [StringField(14, 15)]
        public string Qualification { get; set; }

        [StringField(15, 4)]
        public string Niveau { get; set; }

        [DecimalField(16, 12)]
        public decimal? SalaireMinimum { get; set; }

        [StringField(17, 10)]
        public string Coefficient { get; set; }

        [DateField(18)]
        public DateTime? DateEntreePoste { get; set; }

        [DateField(19)]
        public DateTime? DateSortiePoste { get; set; }

        [StringField(20, 10)]
        public string NatureContrat { get; set; }

        [DateField(21)]
        public DateTime? DateDebutContrat { get; set; }

        [DateField(22)]
        public DateTime? DateFinContrat { get; set; }

        [DateField(23)]
        public DateTime? FinPeriodeEssai { get; set; }

        [StringField(24, 10)]
        public string PlanningAnnuelModele { get; set; }

        [StringField(25, 10)]
        public string CodeFonctionEntreprise { get; set; }

        [StringField(26, 10)]
        public string NumeroBadge { get; set; }

        [StringField(27, 6)]
        public string ZoneReservee { get; set; } = "";

        [DateField(28)]
        public DateTime? DateEmbauche { get; set; }

        [StringField(29, 5)]
        public string CodeEtablissement { get; set; }

        [StringField(30, 2)]
        public string TauxActiviteSalarieTempsPartielBTP { get; set; }

        [StringField(31, 10)]
        public string CodeNaturePeriodeTravailBTP { get; set; }

        [StringField(32, 3)]
        public string ZoneReservee2 { get; set; }

        [EnumField(33)]
        public CategorieProfessionelleBTP CodeCategorieProfessionelleBTP { get; set; }

        [StringField(34, 10)]
        public string CodeQualificationProfessionelleBTP { get; set; }

        [BoolField(35)]
        public bool ValidationQualigaz { get; set; }

        [DateField(36)]
        public DateTime? DateValidationQualigaz { get; set; }

        // 308
        [BoolField(37)]
        public bool CaissesRetraiteBTPCadre { get; set; }

        [BoolField(38)]
        public bool CaissesRetraiteBTPEtam { get; set; }

        [BoolField(39)]
        public bool CaissesRetraiteBTPCNROPro { get; set; }

        [BoolField(40)]
        public bool CaissesRetraiteBTPAutreCaisse { get; set; }

        [BoolField(41)]
        public bool SynchronisationMultiDevis { get; set; }

        [StringField(42, 2)]
        public string ZoneReservee3 { get; set; }

        [EnumField(43)]
        public CodeStatutCotisantBTP CodeStatutCotisantDADSUBTP { get; set; }

        [StringField(44, 19)]
        public string ZoneReservee4 { get; set; }

        // 368
        [StringField(45, 5)]
        public string MetierEmploiDADSUBTP { get; set; }

        [StringField(46, 11)]
        public string ZoneReservee5 { get; set; }

        [DateField(47)]
        public DateTime? DernierEntretienProfessionnel { get; set; }

        [StringField(48, 13)]
        public string HeuresRestantesDIF { get; set; }

        [StringField(49, 1)]
        public string CodeTypeAffiliationRetraiteComplementaire { get; set; }

        [StringField(50, 10)]
        public string CodePoste { get; set; }

        [StringField(51, 5)]
        public string ClassificationQualificationBTP { get; set; }

        [StringField(52, 5)]
        public string NumRattachementCodeCaisse1 { get; set; }

        [StringField(53, 20)]
        public string NumRattachementCodeRattachement1 { get; set; }

        [StringField(54, 5)]
        public string NumRattachementCodeCaisse2 { get; set; }

        [StringField(55, 20)]
        public string NumRattachementCodeRattachement2 { get; set; }

        [StringField(56, 5)]
        public string NumRattachementCodeCaisse3 { get; set; }

        [StringField(57, 20)]
        public string NumRattachementCodeRattachement3 { get; set; }

        [StringField(58, 5)]
        public string NumRattachementCodeCaisse4 { get; set; }

        [StringField(59, 20)]
        public string NumRattachementCodeRattachement4 { get; set; }

        [StringField(60, 5)]
        public string NumRattachementCodeCaisse5 { get; set; }

        [StringField(61, 20)]
        public string NumRattachementCodeRattachement5 { get; set; }

        // 548
        [StringField(62, 20)]
        public string ReferenceContratTravail { get; set; }

        [BoolField(63)]
        public bool ClauseNonConcurrence { get; set; }

        [EnumField(64)]
        public UniteTempsBTP UniteTempsBTP { get; set; }

        [BoolField(65)]
        public bool PortabiliteSantePrevoyance { get; set; }

        [BoolField(66)]
        public bool BulletinsComplementaires { get; set; }

        [StringField(67, 3)]
        public string MotifContrat { get; set; }

        [StringField(68, 10)]
        public string MatriculeSalarieRemplace { get; set; }

        [StringField(69, 1)]
        public string ZoneReservee6 { get; set; }

        [StringField(70, 2)]
        public string CodePopulation { get; set; }

        [StringField(71, 4)]
        public string ZoneReservee7 { get; set; }

        [StringField(72, 14)]
        public string PseudoSiretRattachement { get; set; }

        [StringField(73, 60)]
        public string CommentaireContratTravail { get; set; }
    }
}
