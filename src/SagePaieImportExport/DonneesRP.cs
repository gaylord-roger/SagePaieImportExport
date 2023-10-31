using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// RP
    /// </summary>
    [FixedLengthFile]
    public class DonneesRP
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "RP";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [StringField(3, 10)]
        public string CodeInfoLibre { get; set; }

        [DecimalField(4)]
        public decimal? ValeurDecimale { get; set; }

        [DateField(5)]
        public DateTime? ValeurDate { get; set; }

        [StringField(6, 60)]
        public string ValeurTexte { get; set; }
    }
}
