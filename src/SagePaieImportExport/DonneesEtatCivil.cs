using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 02
    /// </summary>
    [FixedLengthFile]
    public class DonneesEtatCivil
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "02";

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

        [IntField(7, 3)]
        public int Nationalite { get; set; }

        [StringField(8, 10)]
        public string CarteSejourNumero { get; set; }

        [DateField(9)]
        public DateTime? CarteSejourDateExpiration { get; set; }

        [StringField(10, 20)]
        public string CarteSejourDelivreePar { get; set; }

        [DateField(11)]
        public DateTime? NaissanceDate { get; set; }

        [StringField(12, 2)]
        public string NaissanceDepartement { get; set; }

        [StringField(13, 3)]
        public string NaissanceCodeCommune { get; set; }

        [StringField(14, 26)]
        public string NaissanceCommune { get; set; }

        [StringField(15, 13)]
        public string NumeroSecuriteSociale { get; set; }

        [StringField(16, 2)]
        public string NumeroSecuriteSocialeCle { get; set; }

        [StringField(17, 20)]
        public string CentreRattachement { get; set; }

        [StringField(18, 20)]
        public string NumeroAffiliation { get; set; }

        // 208
        [StringField(19, 20)]
        public string BureauPayeur { get; set; }

        [StringField(20, 32)]
        public string AdresseDuCentreRue1 { get; set; }

        [StringField(21, 32)]
        public string AdresseDuCentreRue2 { get; set; }

        [StringField(22, 26)]
        public string AdresseDuCentreCommune { get; set; }

        [StringField(23, 5)]
        public string AdresseDuCentreCodePostal { get; set; }

        [StringField(24, 26)]
        public string AdresseDuCentreBureau { get; set; }

        [StringField(25, 15)]
        public string AdresseDuCentreTelephone { get; set; }

        [EnumField(26)]
        public AdresseOrganismeCotisationEtablissement ChoixAdresseOrganismeCotisationEtablissement { get; set; }

        [EnumField(27)]
        public SituationFamiliale SituationFamiliale { get; set; }

        // 366
        [IntField(28, 2)]
        public int NombreEnfants { get; set; }

        [IntField(29, 2)]
        public int Enfant1Numero { get; set; }

        [StringField(30, 20)]
        public string Enfant1Prenom { get; set; }

        [StringField(31, 30)]
        public string Enfant1Nom { get; set; }

        [DateField(32)]
        public DateTime? Enfant1DateNaissance { get; set; }

        [EnumField(33)]
        public Sexe Enfant1Sexe { get; set; }

        [BoolField(34)]
        public bool Enfant1ACharge { get; set; }


        [IntField(35, 2)]
        public int Enfant2Numero { get; set; }

        [StringField(36, 20)]
        public string Enfant2Prenom { get; set; }

        [StringField(37, 30)]
        public string Enfant2Nom { get; set; }

        [DateField(38)]
        public DateTime? Enfant2DateNaissance { get; set; }

        [EnumField(39)]
        public Sexe Enfant2Sexe { get; set; }

        [BoolField(40)]
        public bool Enfant2ACharge { get; set; }


        [IntField(41, 2)]
        public int Enfant3Numero { get; set; }

        [StringField(42, 20)]
        public string Enfant3Prenom { get; set; }

        [StringField(43, 30)]
        public string Enfant3Nom { get; set; }

        [DateField(44)]
        public DateTime? Enfant3DateNaissance { get; set; }

        [EnumField(45)]
        public Sexe Enfant3Sexe { get; set; }

        [BoolField(46)]
        public bool Enfant3ACharge { get; set; }


        [IntField(47, 2)]
        public int Enfant4Numero { get; set; }

        [StringField(48, 20)]
        public string Enfant4Prenom { get; set; }

        [StringField(49, 30)]
        public string Enfant4Nom { get; set; }

        [DateField(50)]
        public DateTime? Enfant4DateNaissance { get; set; }

        [EnumField(51)]
        public Sexe Enfant4Sexe { get; set; }

        [BoolField(52)]
        public bool Enfant4ACharge { get; set; }


        [IntField(53, 2)]
        public int Enfant5Numero { get; set; }

        [StringField(54, 20)]
        public string Enfant5Prenom { get; set; }

        [StringField(55, 30)]
        public string Enfant5Nom { get; set; }

        [DateField(56)]
        public DateTime? Enfant5DateNaissance { get; set; }

        [EnumField(57)]
        public Sexe Enfant5Sexe { get; set; }

        [BoolField(58)]
        public bool Enfant5ACharge { get; set; }


        [IntField(59, 2)]
        public int Enfant6Numero { get; set; }

        [StringField(60, 20)]
        public string Enfant6Prenom { get; set; }

        [StringField(61, 30)]
        public string Enfant6Nom { get; set; }

        [DateField(62)]
        public DateTime? Enfant6DateNaissance { get; set; }

        [EnumField(63)]
        public Sexe Enfant6Sexe { get; set; }

        [BoolField(64)]
        public bool Enfant6ACharge { get; set; }


        [IntField(65, 2)]
        public int Enfant7Numero { get; set; }

        [StringField(66, 20)]
        public string Enfant7Prenom { get; set; }

        [StringField(67, 30)]
        public string Enfant7Nom { get; set; }

        [DateField(68)]
        public DateTime? Enfant7DateNaissance { get; set; }

        [EnumField(69)]
        public Sexe Enfant7Sexe { get; set; }

        [BoolField(70)]
        public bool Enfant7ACharge { get; set; }


        [IntField(71, 2)]
        public int Enfant8Numero { get; set; }

        [StringField(72, 20)]
        public string Enfant8Prenom { get; set; }

        [StringField(73, 30)]
        public string Enfant8Nom { get; set; }

        [DateField(74)]
        public DateTime? Enfant8DateNaissance { get; set; }

        [EnumField(75)]
        public Sexe Enfant8Sexe { get; set; }

        [BoolField(76)]
        public bool Enfant8ACharge { get; set; }


        [IntField(77, 2)]
        public int Enfant9Numero { get; set; }

        [StringField(78, 20)]
        public string Enfant9Prenom { get; set; }

        [StringField(79, 30)]
        public string Enfant9Nom { get; set; }

        [DateField(80)]
        public DateTime? Enfant9DateNaissance { get; set; }

        [EnumField(81)]
        public Sexe Enfant9Sexe { get; set; }

        [BoolField(82)]
        public bool Enfant9ACharge { get; set; }


        [IntField(83, 2)]
        public int Enfant10Numero { get; set; }

        [StringField(84, 20)]
        public string Enfant10Prenom { get; set; }

        [StringField(85, 30)]
        public string Enfant10Nom { get; set; }

        [DateField(86)]
        public DateTime? Enfant10DateNaissance { get; set; }

        [EnumField(87)]
        public Sexe Enfant10Sexe { get; set; }

        [BoolField(88)]
        public bool Enfant10ACharge { get; set; }


        [StringField(89, 5696)]
        public string Enfants11A12 { get; set; }

        [IntField(90, 2)]
        public int NombreEnfantsRenseignes { get; set; }

        [BoolField(91)]
        public bool NonConnu { get; set; }

        [StringField(92, 3)]
        public string NaissanceCodePays { get; set; }

        [BoolField(93)]
        public bool NaissanceDateInconnue { get; set; }

        [BoolField(94)]
        public bool BulletinDematerialise { get; set; } = false;

        [StringField(95, 40)]
        public string NumeroTechniqueTemporaire { get; set; }
    }
}
