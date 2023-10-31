using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 08
    /// </summary>
    [FixedLengthFile]
    public class DonneesDADS
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "08";

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
        public TravailCIPDZ TravailCIPDZ { get; set; }

        [StringField(8, 4)]
        public string CategorieSocioprofessionelle { get; set; }

        [EnumField(9)]
        public CategorieProfessionelle CategorieProfessionnelle { get; set; }

        [StringField(10, 2)]
        public string ZoneReservee { get; set; } = "  ";

        [IntField(11, 2)]
        public int TauxAccidentDuTravail { get; set; }

        [EnumField(12)]
        public RegimeSecuriteSociale RegimeSecuriteSociale { get; set; }

        [DateField(13)]
        public DateTime? DateDebutEmploi1 { get; set; }

        [DateField(14)]
        public DateTime? DateFinEmploi1 { get; set; }

        [DateField(15)]
        public DateTime? DateDebutEmploi2 { get; set; }

        [DateField(16)]
        public DateTime? DateFinEmploi2 { get; set; }

        [IntField(17, 1)]
        public int SalarieRemunereAuPourboire { get; set; }

        [IntField(18, 1)]
        public int TravailALEtranger { get; set; }

        [IntField(19, 1)]
        public int TravailFrontalier { get; set; }

        [EnumField(20)]
        public ElectionsPrudhomalesCollege ElectionsPrudhommalesCollege { get; set; }

        [EnumField(21)]
        public ElectionsPrudhomalesSection ElectionsPrudhommalesSection { get; set; }

        [StringField(22, 1)]
        public string ZoneReservee2 { get; set; }

        [DateField(23)]
        public DateTime? DateDebutIRCANTECPeriodeInitiale { get; set; }

        [DateField(24)]
        public DateTime? DateFinIRCANTECPeriodeInitiale { get; set; }

        [IntField(25, 3)]
        public int DureeIRCANTECPeriodeInitiale { get; set; }

        [IntField(26, 2)]
        public int PlafondSecuriteSocialeIRCANTECPeriodeInitiale { get; set; }

        [StringField(27, 1)]
        public string CodeConditionTravailIRCANTECPeriodeInitiale { get; set; }

        [StringField(28, 3)]
        public string CodeFonctionIRCANTECPeriodeInitiale { get; set; }

        [StringField(29, 10)]
        public string CategorieSocioprofessionelle2 { get; set; }

        [IntField(30, 3)]
        public int ElectionsPrudhommalesContratDeDroit { get; set; }

        [IntField(31, 1)]
        public int CodeEmploiMultipleIRCANTEC { get; set; }

        [StringField(32, 10)]
        public string CodeConditionTravailIRCANTEC { get; set; }

        [StringField(33, 2)]
        public string ZoneReservee3 { get; set; } = "  ";

        [BoolField(34)]
        public bool ExonereAGFF { get; set; }

        [BoolField(34)]
        public bool RegimeAslaceMoselle { get; set; }

        [StringField(35, 6)]
        public string ZoneReservee4 { get; set; } = "      ";
    }
}
