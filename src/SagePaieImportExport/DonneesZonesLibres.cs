using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// ZL
    /// </summary>
    [FixedLengthFile]
    public class DonneesZonesLibres
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "ZL";

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
        public DateTime? DateLibre1 { get; set; }

        [DateField(8)]
        public DateTime? DateLibre2 { get; set; }

        [DateField(9)]
        public DateTime? DateLibre3 { get; set; }

        [DateField(10)]
        public DateTime? DateLibre4 { get; set; }

        [DateField(11)]
        public DateTime? FourchetteLibre1Date1 { get; set; }

        [DateField(12)]
        public DateTime? FourchetteLibre1Date2 { get; set; }

        [DateField(13)]
        public DateTime? FourchetteLibre2Date1 { get; set; }

        [DateField(14)]
        public DateTime? FourchetteLibre2Date2 { get; set; }

        [DecimalField(15, 15)]
        public decimal? MontantLibre1 { get; set; }

        [DecimalField(16, 15)]
        public decimal? MontantLibre2 { get; set; }

        // 179
        [StringField(17, 60)]
        public string CommentaireLibre { get; set; }

        [DecimalField(18, 15)]
        public decimal? TauxLibre1 { get; set; }

        [DecimalField(19, 15)]
        public decimal? TauxLibre2 { get; set; }

        [DecimalField(20, 15)]
        public decimal? TauxLibre3 { get; set; }

        [StringField(21, 20)]
        public string TexteLibre20Car1 { get; set; }

        [StringField(22, 20)]
        public string TexteLibre20Car2 { get; set; }

        [StringField(23, 20)]
        public string TexteLibre20Car3 { get; set; }

        [StringField(24, 10)]
        public string TexteLibre10Car1 { get; set; }

        [StringField(25, 10)]
        public string TexteLibre10Car2 { get; set; }

        [StringField(26, 10)]
        public string TexteLibre10Car3 { get; set; }

        [StringField(27, 10)]
        public string TexteLibre10Car4 { get; set; }

        [StringField(28, 10)]
        public string TexteLibre10Car5 { get; set; }
    }
}
