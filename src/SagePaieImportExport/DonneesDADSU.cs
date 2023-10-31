using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// DU
    /// </summary>
    [FixedLengthFile]
    public class DonneesDADSU
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "DU";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [StringField(3, 40)]
        public string PrenomUsage { get; set; }

        [StringField(4, 40)]
        public string Surnom { get; set; }

        [DateField(5)]
        public DateTime? DateEntreeDansProfession { get; set; }

        [DecimalField(6, 8)]
        public decimal? AncienneteDansProfession { get; set; }

        [DecimalField(7, 12)]
        public decimal? SalaireMoyen { get; set; }

        [EnumField(8, 3)]
        public UniteTempsTravailArret UniteTempsTravail { get; set; }

        [EnumField(9, 3)]
        public UniteTempsTravailArret UniteTempsArret { get; set; }

        [StringField(10, 3)]
        public string RegimeBaseObligatoire { get; set; }

        [StringField(11, 3)]
        public string StatutProfessionel { get; set; }

        [EnumField(13, 2)]
        public CategorielAgircArrco CategorielAgircArrco { get; set; }

        [EnumField(14, 3)]
        public CaracteristiqueActivite CaracteristiqueActivite { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(15, 11)]
        public string ZoneReservee2 { get; set; }

        [StringField(16, 14)]
        public string SiretLieuGeographiqueTravail { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(17, 2)]
        public string ZoneReservee3 { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(18, 1)]
        public string ZoneReservee4 { get; set; }

        [EnumField(19)]
        public DecalagePaie DecalagePaie { get; set; }

        [StringField(20, 1)]
        public string DetachementEtrangerActivite { get; set; }

        [StringField(21, 1)]
        public string PeriodeDePaiementCongeActivite { get; set; }

        [StringField(22, 1)]
        public string CodeBeneficiaireAssuranceChomage { get; set; }

        [StringField(23, 20)]
        public string NumeroAffiliationFondsNationauxDeCompensation { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(24, 833)]
        public string ZoneReservee5 { get; set; }

        [StringField(25, 3)]
        public string ChangementSituationParticulier { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(26, 12)]
        public string ZoneReservee6 { get; set; }

        [EnumField(27, 1)]
        public CategorielConvention CategorielConvention { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(28, 2)]
        public string ZoneReservee7 { get; set; }

        [StringField(29, 1)]
        public string ClasseExtensionCNBF { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(30, 2)]
        public string ZoneReservee8 { get; set; } = "00";

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(31, 4)]
        public string ZoneReservee9 { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(32, 7)]
        public string ZoneReservee10 { get; set; }

        [EnumField(33, 1)]
        public UniteTempsTravail UniteTempsDeTravail { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(34, 1)]
        public string ZoneReservee11 { get; set; }

        [StringField(35, 1)]
        public string CaisseCongesPayes { get; set; }

        [StringField(36, 5)]
        public string NumeroCaisseCongesPayes { get; set; }

        [DateField(37)]
        public DateTime? DateSignatureConventionEmploiAide { get; set; }

        [StringField(38, 10)]
        public string ReferenceConventionEmploiAide { get; set; }

        [EnumField(39, 2)]
        public ModaliteExerciceTravail ModaliteExerciceTravail { get; set; }

        [EnumField(40, 2)]
        public PeriodicitePaiement PeriodicitePaiement { get; set; }

        [EnumField(41, 2)]
        public UniteTempsTravail UniteTempsDeTravail3 { get; set; }

        [EnumField(43, 2)]
        public ModaliteActivite ModaliteActivite { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(44, 1)]
        public string ZoneReservee13 { get; set; }

        [EnumField(45, 1)]
        public LienParente LienParente { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(46, 1)]
        public string ZoneReservee14 { get; set; }

        [EnumField(47)]
        public AssujetissementChomage AssujetissementChomage { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(48, 1)]
        public string ZoneReservee15 { get; set; }

        [EnumField(49)]
        public AssujetissementAGS AssujetissementAGS { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [StringField(50, 1)]
        public string ZoneReservee16 { get; set; }

        [EnumField(51)]
        public Exonerations Exonerations { get; set; }

        [EnumField(52)]
        public EmployeurPublic EmployeurPublic { get; set; }

        [StringField(53, 10)]
        public string NumeroConvention { get; set; }

        [StringField(54, 12)]
        public string NumeroEmployeur { get; set; }

        [StringField(55, 6)]
        public string CodeAffectation { get; set; }

        [IntField(56, 3)]
        public int RisqueMaladie { get; set; }

        [IntField(57, 3)]
        public int RisqueAccidentDuTravail { get; set; }

        [IntField(58, 3)]
        public int RisqueVieillesse { get; set; }
    }
}
