using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 14
    /// </summary>
    [FixedLengthFile]
    public class DonneesSalarie
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "14";

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

        [StringField(7, 2)]
        public string CodeSituationAvecSalaire { get; set; }
        
        [IntField(8, 3)]
        public int? CodeCategorieProfessionnelleNormalisee { get; set; }
        
        [StringField(9, 15)]
        public string DureeTravailTP { get; set; }

        [StringField(10, 1)]
        public string UniteCalculTP { get; set; }

        [StringField(11, 15)]
        public string DureeMaladie { get; set; }

        [StringField(12, 15)]
        public string DureeChomagePartiel { get; set; }

        [StringField(13, 4)]
        public string CodeEmploiPCS { get; set; }

        [StringField(14, 4)]
        public string ZoneReservee { get; set; }

        [StringField(15, 3)]
        public string CodeExo { get; set; }

        [StringField(16, 1)]
        public string CodeDirigeant { get; set; }

        [StringField(17, 6)]
        public string CentrePayeur { get; set; }

        [StringField(18, 4)]
        public string ZoneReservee2 { get; set; }

        [StringField(19, 1)]
        public string MiseAJourIdentifiant { get; set; }

        [StringField(20, 26)]
        public string ZoneLibreServiceEntreprise { get; set; }
        
        [StringField(21, 24)]
        public string ZoneReserve3 { get; set; }

        [EnumField(22)]
        public CategorieDUCS? CategorieDUCS { get; set; }

        [StringField(23, 7)]
        public string Regime { get; set; }

        [StringField(24, 2)]
        public string ZoneReserve4 { get; set; }

        [EnumField(25)]
        public UniteTempsTravailArret? CodeUniteDureeDeTravail { get; set; }
    }
}
