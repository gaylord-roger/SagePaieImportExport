using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 05
    /// </summary>
    [FixedLengthFile]
    public class DonneesSalaire
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "05";

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

        [StringField(7, 4)]
        public string BulletinModele { get; set; }

        [EnumField(8)]
        public TypeSalaire TypeSalaire { get; set; }

        [DecimalField(9, 12)]
        public decimal SalaireBase { get; set; }

        [DecimalField(10, 12)]
        public decimal SalaireHoraire { get; set; }

        [StringField(11, 12)]
        public string Horaire { get; set; }

        [DecimalField(12, 12)]
        public decimal HoraireHebdomadaire { get; set; }

        [DecimalField(13, 12)]
        public decimal SalaireBaseAnnuel { get; set; }

        // 134
        [DecimalField(14, 5)]
        public decimal NombreMois { get; set; }

        [DateField(15)]
        public DateTime? DebutDernierePeriodePaie { get; set; }

        [DateField(16)]
        public DateTime? FinDernierePeriodePaie { get; set; }

        [DateField(17)]
        public DateTime? DateDerniereCloture { get; set; }

        [BoolField(18)]
        public bool RegularisationSystematique { get; set; }

        [IntField(19, 1)]
        public int NombreEmployeurs { get; set; }

        [IntField(20, 1)]
        public int Employeur1Numero { get; set; }

        [DateField(21)]
        public DateTime? Employeur1DateDebut { get; set; }

        [DateField(22)]
        public DateTime? Employeur1DateFin { get; set; }

        [StringField(23, 40)]
        public string Employeur1RaisonSociale { get; set; }

        [DecimalField(24, 12)]
        public decimal Employeur1MontantBrut { get; set; }

        [StringField(25, 32)]
        public string Employeur1Adresse { get; set; }

        [StringField(26, 32)]
        public string Employeur1ComplementAdresse { get; set; }

        [StringField(27, 26)]
        public string Employeur1Commune { get; set; } = "";

        [StringField(28, 5)]
        public string Employeur1CodePostal { get; set; }

        [StringField(29, 26)]
        public string Employeur1BureauDistributeur { get; set; }

        [StringField(30, 15)]
        public string Employeur1Telephone { get; set; }


        [IntField(31, 1)]
        public int Employeur2Numero { get; set; }

        [DateField(32)]
        public DateTime? Employeur2DateDebut { get; set; }

        [DateField(33)]
        public DateTime? Employeur2DateFin { get; set; }

        [StringField(34, 40)]
        public string Employeur2RaisonSociale { get; set; }

        [DecimalField(35)]
        public decimal Employeur2MontantBrut { get; set; }

        [StringField(36, 32)]
        public string Employeur2Adresse { get; set; }

        [StringField(37, 32)]
        public string Employeur2ComplementAdresse { get; set; }

        [StringField(38, 26)]
        public string Employeur2Commune { get; set; } = "";

        [StringField(39, 5)]
        public string Employeur2CodePostal { get; set; }

        [StringField(40, 26)]
        public string Employeur2BureauDistributeur { get; set; }

        [StringField(41, 15)]
        public string Employeur2Telephone { get; set; }


        [IntField(42, 1)]
        public int Employeur3Numero { get; set; }

        [DateField(43)]
        public DateTime? Employeur3DateDebut { get; set; }

        [DateField(44)]
        public DateTime? Employeur3DateFin { get; set; }

        [StringField(45, 40)]
        public string Employeur3RaisonSociale { get; set; }

        [DecimalField(46)]
        public decimal Employeur3MontantBrut { get; set; }

        [StringField(47, 32)]
        public string Employeur3Adresse { get; set; }

        [StringField(48, 32)]
        public string Employeur3ComplementAdresse { get; set; }

        [StringField(49, 26)]
        public string Employeur3Commune { get; set; } = "";

        [StringField(50, 5)]
        public string Employeur3CodePostal { get; set; }

        [StringField(51, 26)]
        public string Employeur3BureauDistributeur { get; set; }

        [StringField(52, 15)]
        public string Employeur3Telephone { get; set; }


        [IntField(53, 1)]
        public int Employeur4Numero { get; set; }

        [DateField(54)]
        public DateTime? Employeur4DateDebut { get; set; }

        [DateField(55)]
        public DateTime? Employeur4DateFin { get; set; }

        [StringField(56, 40)]
        public string Employeur4RaisonSociale { get; set; }

        [DecimalField(57, 12)]
        public decimal Employeur4MontantBrut { get; set; }

        [StringField(58, 32)]
        public string Employeur4Adresse { get; set; }

        [StringField(59, 32)]
        public string Employeur4ComplementAdresse { get; set; }

        [StringField(60, 26)]
        public string Employeur4Commune { get; set; } = "";

        [StringField(61, 5)]
        public string Employeur4CodePostal { get; set; }

        [StringField(62, 26)]
        public string Employeur4BureauDistributeur { get; set; }

        [StringField(63, 15)]
        public string Employeur4Telephone { get; set; }


        [IntField(64, 1)]
        public int Employeur5Numero { get; set; }

        [DateField(65)]
        public DateTime? Employeur5DateDebut { get; set; }

        [DateField(66)]
        public DateTime? Employeur5DateFin { get; set; }

        [StringField(67, 40)]
        public string Employeur5RaisonSociale { get; set; }

        [DecimalField(68, 12)]
        public decimal Employeur5MontantBrut { get; set; }

        [StringField(69, 32)]
        public string Employeur5Adresse { get; set; }

        [StringField(70, 32)]
        public string Employeur5ComplementAdresse { get; set; }

        [StringField(71, 26)]
        public string Employeur5Commune { get; set; } = "";

        [StringField(72, 5)]
        public string Employeur5CodePostal { get; set; }

        [StringField(73, 26)]
        public string Employeur5BureauDistributeur { get; set; }

        [StringField(74, 15)]
        public string Employeur5Telephone { get; set; }


        // 308
        [DateField(75)]
        public DateTime? DernierEnregistrementFeuilleDeTemps { get; set; }

        [DateField(76)]
        public DateTime? DernierEnregistrementHeureSupplementaire { get; set; }

        [DateField(77)]
        public DateTime? DernierEnregistrementReposCompensateur { get; set; }

        [BoolField(78)]
        public bool NonConnuMultiEmployeurs { get; set; }

        [BoolField(79)]
        public bool RemunereALaTache { get; set; }

        [IntField(80, 1)]
        public int NombreMultiEmployeursRenseignes { get; set; }

        [StringField(81, 6)]
        public string ZoneReservee { get; private set; } = "";

        [DecimalField(82, 6)]
        public decimal EquivalentTempsPlein { get; set; }
        /*
        [StringField(83, 2)]
        public string ZoneReservee2 { get; set; } = "00";*/

        [EnumField(84, 2)]
        public PeriodicitePaiement PeriodicitePaiement { get; set; }

        // 1263
        [EnumField(85, 2)]
        public UniteTempsTravail UniteTempsTravail { get; set; }

        [EnumField(86, 2)]
        public ModaliteActivite ModaliteActivite { get; set; }

        [StringField(87, 2)]
        public string Categorie { get; set; }

        [DecimalField(88, 12)]
        public decimal? QuotiteTravailMensuelle { get; set; }

        [StringField(89, 1)]
        public string ExclusCICE { get; set; }

        [StringField(90, 1)]
        public string ExclusDispositifDSN { get; set; }

        [StringField(91, 2)]
        public string MotifExclusionDSN { get; set; }
    }
}
