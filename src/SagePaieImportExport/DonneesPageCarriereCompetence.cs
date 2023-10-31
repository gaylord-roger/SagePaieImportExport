using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// SA
    /// </summary>
    [FixedLengthFile]
    public class DonneesPageCarriereCompetence
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "SA";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [StringField(3, 10)]
        public string CodeCompetenceAcquise { get; set; }

        [DateField(4)]
        public DateTime? DateAcquisitionCompetence { get; set; }

        [StringField(5, 2)]
        public string ZoneReservee { get; set; }

        [EnumField(6)]
        public NiveauCompetence NiveauCompetence { get; set; }

        [StringField(7, 2)]
        public string ZoneReservee2 { get; set; }

        [StringField(8, 3)]
        public string Ponderation { get; set; }
    }
}
