using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 03
    /// </summary>
    [FixedLengthFile]
    public class DonneesLieuTravail
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "03";

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
        public DateTime? DateEmbauche { get; set; }

        [DateField(8)]
        public DateTime? DateDepart { get; set; }

        [StringField(9, 3)]
        public string MotifDepart { get; set; }

        [BoolField(10)]
        public bool SalarieAbsentASupprimerApresClotureAnnuelle { get; set; }

        [DateField(11)]
        public DateTime? DateEntreeEtablissement { get; set; }

        [StringField(12, 2)]
        public string MotifEntree { get; set; }

        [DateField(13)]
        public DateTime? DateSortieEtablissement { get; set; }

        [BoolField(14)]
        public bool MiseEnSommeil { get; set; }

        [DateField(15)]
        public DateTime? DateDebutArret1 { get; set; }

        [DateField(16)]
        public DateTime? DateFinArret1 { get; set; }

        [StringField(17, 10)]
        public string MotifArret1 { get; set; }

        [DateField(18)]
        public DateTime? DateDebutArret2 { get; set; }

        [DateField(19)]
        public DateTime? DateFinArret2 { get; set; }

        [StringField(20, 10)]
        public string MotifArret2 { get; set; }

        [DateField(21)]
        public DateTime? DateDebutArret3 { get; set; }

        [DateField(22)]
        public DateTime? DateFinArret3 { get; set; }

        [StringField(23, 10)]
        public string MotifArret3 { get; set; }

        [BoolField(24)]
        public bool LieuTravailDifferentDeLEtablissement { get; set; }

        [StringField(25, 32)]
        public string LieuTravailEtablissementAdresse { get; set; }

        [StringField(26, 32)]
        public string LieuTravailEtablissementComplement { get; set; }

        [StringField(27, 26)]
        public string LieuTravailEtablissementCommune { get; set; }

        [StringField(28, 5)]
        public string LieuTravailEtablissementCodePostal { get; set; }

        [StringField(29, 26)]
        public string LieuTravailEtablissementBureauDistributeur { get; set; }

        // 308
        [StringField(30, 15)]
        public string LieuTravailEtablissementTelephone { get; set; }

        [DateField(31)]
        public DateTime? DateAnciennete { get; set; }

        [StringField(32, 3)]
        public string LieuTravailCodePays { get; set; }

        [DateField(33)]
        public DateTime? DernierJourTravaillePaye { get; set; }

        [DateField(34)]
        public DateTime? EngagementProcedure { get; set; }

        [DateField(35)]
        public DateTime? NotificationRupture { get; set; }

        // 386
        [IntField(36, 3)]
        public int Preavis1Realisation { get; set; }

        [DateField(37)]
        public DateTime? Preavis1Debut { get; set; }

        [DateField(38)]
        public DateTime? Preavis1Fin { get; set; }

        [IntField(39, 3)]
        public int Preavis2Realisation { get; set; }

        [DateField(40)]
        public DateTime? Preavis2Debut { get; set; }

        [DateField(41)]
        public DateTime? Preavis2Fin { get; set; }

        [IntField(42, 3)]
        public int Preavis3Realisation { get; set; }

        [DateField(43)]
        public DateTime? Preavis3Debut { get; set; }

        [DateField(44)]
        public DateTime? Preavis3Fin { get; set; }


        [StringField(45, 15)]
        public string TelephoneProfessionel { get; set; }

        [StringField(46, 15)]
        public string PortalProfessionel { get; set; }

        [StringField(47, 15)]
        public string FaxProfessionel { get; set; }

        [StringField(48, 128)]
        public string EmailProfessionel { get; set; }

        // 628
        [BoolField(49)]
        public bool InformationProfessionelleAccordSalarie { get; set; }

        [DateField(50)]
        public DateTime? MiseEnSommeilDebut { get; set; }

        [DateField(51)]
        public DateTime? MiseEnSommeilFin { get; set; }

        [StringField(52, 3)]
        public string MiseEnSommeilMotif { get; set; }

        [BoolField(53)]
        public bool SalarieDesactive { get; set; }

        [StringField(54, 50)]
        public string EnseigneLieuTravailDifferentEtablissement { get; set; }

        [StringField(55, 5)]
        public string CodeAPELieuTravailDifferentEtablissement { get; set; }

        [StringField(56, 50)]
        public string CodeDistributionALEtrangerLieuTravailDifferentEtablissement { get; set; }

        [BoolField(57)]
        public bool AEDTransmise { get; set; }

        [BoolField(58)]
        public bool DSNFCTTransmise { get; set; }

        [DateField(59)]
        public DateTime? DateSignatureRuptureConventionnelle { get; set; }

        [BoolField(60)]
        public bool TransactionEnCours { get; set; }

        [StringField(61, 14)]
        public string ZoneReservee { get; set; } = "     000      ";
    }
}
