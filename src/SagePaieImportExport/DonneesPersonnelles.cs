using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// Données personnelles
    /// Id: 11
    /// </summary>
    [FixedLengthFile]
    public class DonneesPersonnelles
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "11";

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

        [EnumField(7)]
        public SituationMilitaire? SituationMilitaire { get; set; }

        [DateField(8)]
        public DateTime? SituationMilitaireDateDebut { get; set; }

        [DateField(9)]
        public DateTime? SituationMilitaireDateFin { get; set; }

        [IntField(10, 1)]
        public int NombrePermisConduire { get; set; }

        [StringField(11, 4)]
        public string Permis1Categorie { get; set; }

        [StringField(12, 20)]
        public string Permis1Numero { get; set; }

        [DateField(13)]
        public DateTime? Permis1DateObtention { get; set; }

        [IntField(14, 1)]
        public int Permis1Permanent { get; set; }

        [DateField(15)]
        public DateTime? Permis1DateExpiration { get; set; }

        [IntField(16, 2)]
        public int Permis1NombreDePoints { get; set; }


        [StringField(17, 4)]
        public string Permis2Categorie { get; set; }

        [StringField(18, 20)]
        public string Permis2Numero { get; set; }

        [DateField(19)]
        public DateTime? Permis2DateObtention { get; set; }

        [IntField(20, 1)]
        public int Permis2Permanent { get; set; }

        [DateField(21)]
        public DateTime? Permis2DateExpiration { get; set; }

        [IntField(22, 2)]
        public int Permis2NombreDePoints { get; set; }


        [StringField(23, 4)]
        public string Permis3Categorie { get; set; }

        [StringField(24, 20)]
        public string Permis3Numero { get; set; }

        [DateField(25)]
        public DateTime? Permis3DateObtention { get; set; }

        [IntField(26, 1)]
        public int Permis3Permanent { get; set; }

        [DateField(27)]
        public DateTime? Permis3DateExpiration { get; set; }

        [IntField(28, 2)]
        public int Permis3NombreDePoints { get; set; }


        [StringField(29, 4)]
        public string Permis4Categorie { get; set; }

        [StringField(30, 20)]
        public string Permis4Numero { get; set; }

        [DateField(31)]
        public DateTime? Permis4DateObtention { get; set; }

        [IntField(32, 1)]
        public int Permis4Permanent { get; set; }

        [DateField(33)]
        public DateTime? Permis4DateExpiration { get; set; }

        [IntField(34, 2)]
        public int Permis4NombreDePoints { get; set; }


        [StringField(35, 4)]
        public string Permis5Categorie { get; set; }

        [StringField(36, 20)]
        public string Permis5Numero { get; set; }

        [DateField(37)]
        public DateTime? Permis5DateObtention { get; set; }

        [IntField(38, 1)]
        public int Permis5Permanent { get; set; }

        [DateField(39)]
        public DateTime? Permis5DateExpiration { get; set; }

        [IntField(40, 2)]
        public int Permis5NombreDePoints { get; set; }

        // 326
        [IntField(41, 3)]
        public int Langue1Intitule { get; set; }

        [EnumField(42)]
        public LangueAptitude Langue1Aptitude { get; set; }


        [IntField(43, 3)]
        public int Langue2Intitule { get; set; }

        [EnumField(44)]
        public LangueAptitude Langue2Aptitude { get; set; }

        [IntField(45, 3)]
        public int Langue3Intitule { get; set; }

        [EnumField(46)]
        public LangueAptitude Langue3Aptitude { get; set; }

        [IntField(47, 3)]
        public int Langue4Intitule { get; set; }

        [EnumField(48)]
        public LangueAptitude Langue4Aptitude { get; set; }

        [IntField(49, 3)]
        public int Langue5Intitule { get; set; }

        [EnumField(50)]
        public LangueAptitude Langue5Aptitude { get; set; }

        [IntField(51, 3)]
        public int Langue6Intitule { get; set; }

        [EnumField(52)]
        public LangueAptitude Langue6Aptitude { get; set; }

        [IntField(53, 3)]
        public int Langue7Intitule { get; set; }

        [EnumField(54)]
        public LangueAptitude Langue7Aptitude { get; set; }

        [IntField(55, 3)]
        public int Langue8Intitule { get; set; }

        [EnumField(56)]
        public LangueAptitude Langue8Aptitude { get; set; }

        [IntField(57, 3)]
        public int Langue9Intitule { get; set; }

        [EnumField(58)]
        public LangueAptitude Langue9Aptitude { get; set; }

        [IntField(59, 3)]
        public int Langue10Intitule { get; set; }

        [EnumField(60)]
        public LangueAptitude Langue10Aptitude { get; set; }

        // 366
        [IntField(61, 1)]
        public int NombreDeDiplomes { get; set; }


        [StringField(62, 20)]
        public string Diplome1Intitule { get; set; }

        [DateField(63)]
        public DateTime? Diplome1DateObtention { get; set; }

        [StringField(64, 20)]
        public string Diplome1Ecole { get; set; }

        [StringField(65, 20)]
        public string Diplome2Intitule { get; set; }

        [DateField(66)]
        public DateTime? Diplome2DateObtention { get; set; }

        [StringField(67, 20)]
        public string Diplome2Ecole { get; set; }

        [StringField(68, 20)]
        public string Diplome3Intitule { get; set; }

        [DateField(69)]
        public DateTime? Diplome3DateObtention { get; set; }

        [StringField(70, 20)]
        public string Diplome3Ecole { get; set; }

        [StringField(71, 20)]
        public string Diplome4Intitule { get; set; }

        [DateField(72)]
        public DateTime? Diplome4DateObtention { get; set; }

        [StringField(73, 20)]
        public string Diplome4Ecole { get; set; }

        [StringField(74, 20)]
        public string Diplome5Intitule { get; set; }

        [DateField(75)]
        public DateTime? Diplome5DateObtention { get; set; }

        [StringField(76, 20)]
        public string Diplome5Ecole { get; set; }

        [StringField(77, 10)]
        public string Permis1Code { get; set; }

        [StringField(78, 10)]
        public string Permis2Code { get; set; }

        [StringField(79, 10)]
        public string Permis3Code { get; set; }

        [StringField(80, 10)]
        public string Permis4Code { get; set; }

        [StringField(81, 10)]
        public string Permis5Code { get; set; }


        [StringField(82, 10)]
        public string Langue1Code { get; set; }

        [StringField(83, 10)]
        public string Langue2Code { get; set; }

        [StringField(84, 10)]
        public string Langue3Code { get; set; }

        [StringField(85, 10)]
        public string Langue4Code { get; set; }

        [StringField(86, 10)]
        public string Langue5Code { get; set; }

        [StringField(87, 10)]
        public string Langue6Code { get; set; }

        [StringField(88, 10)]
        public string Langue7Code { get; set; }

        [StringField(89, 10)]
        public string Langue8Code { get; set; }

        [StringField(90, 10)]
        public string Langue9Code { get; set; }

        [StringField(91, 10)]
        public string Langue10Code { get; set; }

        [StringField(92, 10)]
        public string Diplome1Code { get; set; }

        [StringField(93, 10)]
        public string Diplome2Code { get; set; }

        [StringField(94, 10)]
        public string Diplome3Code { get; set; }

        [StringField(95, 10)]
        public string Diplome4Code { get; set; }

        [StringField(96, 10)]
        public string Diplome5Code { get; set; }
    }
}
