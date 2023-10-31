using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// 09
    /// </summary>
    [FixedLengthFile]
    public class DonneesFiscales
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "09";

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

        [BoolField(7)]
        public bool FraisProfessionels { get; set; }

        [BoolField(8)]
        public bool AllocationForfaitaire { get; set; }

        [BoolField(9)]
        public bool FraisSurJustificatif { get; set; }

        [BoolField(10)]
        public bool PriseEnChargeParEmployeur { get; set; }

        [BoolField(11)]
        public bool RemboursementParAvance { get; set; }

        [DecimalField(12, 7)]
        public decimal DeductionForfaitaire { get; set; }

        [EnumField(13)]
        public OptionDeductionSupplementaire OptionDeDeductionSupplementaire { get; set; }

        [StringField(14, 6)]
        public string TaxesSurLesSalairesEtablissementAgglomerant { get; set; }

        [IntField(15, 1)]
        public int AutresRemboursements { get; set; }

        [StringField(16, 3)]
        public string ZoneReservee { get; set; } = "   ";

        [StringField(17, 10)]
        public string ZoneReservee2 { get; set; }
    }
}
